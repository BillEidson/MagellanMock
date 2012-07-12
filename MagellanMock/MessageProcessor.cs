using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MagellanMock
{
    public class MessageProcessor
    {
        static string[] crnlToken = new string[] { "\r\n" };

        public List<ParsedResult> Execute(string fileName, bool autoResponse)
        {
            var rb = new NextGen.CHS.MagellanHandlerLib.RequestBuilder();
            var fileData = File.ReadAllText(fileName);
            var lines = fileData.Split(crnlToken, StringSplitOptions.RemoveEmptyEntries);
            var fileNamePart = Path.GetFileNameWithoutExtension(fileName);
            var result = new List<ParsedResult>();
            var IsAuthorization = false;


            Dictionary<string, string> fieldMap = null;

            foreach (var line in lines)
            {
                string definitionXml = string.Empty;

                if (fileNamePart.StartsWith("D"))
                    definitionXml = rb.DischargeXml.OuterXml;
                else
                {
                    definitionXml = rb.AuthorizationXml.OuterXml;
                    IsAuthorization = true;
                }

                fieldMap = GetFieldMap(definitionXml, line);

                result.Add(new ParsedResult
                            {
                                FieldMap = fieldMap,
                                Line = line,
                                Key = line.Substring(0, 9),
                                FileName = fileName,
                                Response = autoResponse ? BuildResponse(definitionXml,
                                                                          new MessageBuildArguments
                                                                          {
                                                                              IsAuthorization = IsAuthorization,
                                                                              Accepted = true,
                                                                              FieldMap = fieldMap,
                                                                              SetMATNumber = true,
                                                                              FileName = fileName
                                                                          })
                                                        : null
                            });
            }
            return result;
        }

        Dictionary<string, string> GetFieldMap(string definitionDocXml, string line)
        {
            var doc = XDocument.Parse(definitionDocXml);
            var fieldMap = new Dictionary<string, string>();

            foreach (var item in doc.Descendants().Where(w => w.Name == "Item"))
            {
                var targetField = item.Descendants().Single(w => w.Name == "TargetField");
                var sp = (int)targetField.Attribute("StartingPosition") - 1;
                var ep = (int)targetField.Attribute("EndPosition");

                if (ep > line.Length)
                    ep = line.Length;

                string di = "";
                if (ep - sp >= 0)
                    di = line.Substring(sp, ep - sp).Replace("?", "").Trim();

                "{0} {1}".NTrace((string)item.Attribute("Name"), di);
                fieldMap.Add((string)item.Attribute("Name"), di);

            }
            return fieldMap;
        }

        static int NextMATNumber = 123456789;
        static string GenerateNextMATNumber()
        {
            return GetString(9, "R", "0", (++NextMATNumber).ToString());
        }

        public string BuildResponse(string definitionXml, MessageBuildArguments args)
        {
            var doc = XDocument.Parse(definitionXml);
            var sb = new StringBuilder();

            foreach (var item in doc.Descendants().Where(w => w.Name == "Item"))
            {
                var targetField = item.Descendants().Single(w => w.Name == "TargetField");
                var width = (int)targetField.Attribute("Width");
                var justify = (string)targetField.Attribute("Justify");
                var pad = (string)targetField.Attribute("Pad");
                var code = (string)targetField.Attribute("Code");
                var inputField = (string)item.Attribute("Name");
                var inputString = args.FieldMap[inputField];

                switch (inputField)
                {
                    case "MAT":
                        if (args.IsAuthorization)
                            inputString = args.SetMATNumber && string.IsNullOrEmpty(inputString) ? GenerateNextMATNumber() : inputString;
                        else
                            inputString = args.SetMATNumber ? !string.IsNullOrEmpty(args.MAT) ? args.MAT : inputString : inputString;
                        break;
                    case "Error":
                        inputString = args.SetErrors ? args.Errors[0] : inputString;
                        break;
                    case "ACCEPTED":
                        inputString = args.Accepted ? "ACCEPTED" : inputString;
                        break;
                }

                string fieldValue = GetString(width, justify, pad, inputString);
                sb.Append(fieldValue);
            }
            return sb.ToString();
        }

        static string GetString(int width, string justify, string pad, string input)
        {
            string output = "";
            if (input.Length < width)
            {
                string formatString = string.Format("{{0,-{0}}}", width);
                if (justify == "R")
                    formatString = string.Format("{{0,{0}}}", width);

                output = string.Format(formatString, input);
            }
            else
                output = input.Substring(0, width);

            return output;
        }
    }

}

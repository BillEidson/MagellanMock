using System.Collections.Generic;

namespace MagellanMock
{
   public class ParsedResult
   {
      public Dictionary<string, string> FieldMap { get; set; }

      public string FileName { get; set; }

      public string Key { get; set; }

      public string Line { get; set; }

      public string Response { get; set; }
   }
}
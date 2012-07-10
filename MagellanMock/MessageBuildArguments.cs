using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagellanMock
{
    public class MessageBuildArguments
    {
        public bool IsAuthorization { get; set; }
        public string FileName { get; set; }

        public string MAT { get; set; }
        public bool SetMATNumber { get; set; }

        public List<string> Errors { get; set; }
        public bool SetErrors { get; set; }

        public bool Accepted { get; set; }
        public Dictionary<string, string> FieldMap { get; set; }
    }
}

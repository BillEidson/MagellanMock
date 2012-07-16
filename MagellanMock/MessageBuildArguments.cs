using System.Collections.Generic;

namespace MagellanMock
{
   public class MessageBuildArguments
   {
      public bool Accepted { get; set; }

      public List<string> Errors { get; set; }

      public Dictionary<string, string> FieldMap { get; set; }

      public string FileName { get; set; }

      public bool IsAuthorization { get; set; }

      public string MAT { get; set; }

      public bool SetErrors { get; set; }

      public bool SetMATNumber { get; set; }
   }
}
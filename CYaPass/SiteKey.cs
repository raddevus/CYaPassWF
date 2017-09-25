using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace CYaPass
{
    public class SiteKey 
    {
        public int MaxLength { get; set; }
        public bool HasSpecialChars { get; set; }
        public bool HasUpperCase { get; set; }

        public String Key { get; set; }
        public SiteKey(String key)
        {
            this.Key = key;
        }

        [JsonConstructor ]
        public SiteKey(String key, int maxLength=0, bool hasSpecicalChars=false, bool hasUpperCase=false)
        {
            this.Key = key;
            this.MaxLength = maxLength;
            this.HasSpecialChars = hasSpecicalChars;
            this.HasUpperCase = hasUpperCase;
        }
    }
}

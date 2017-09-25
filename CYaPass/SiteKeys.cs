using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CYaPass
{
    class SiteKeys : List<SiteKey>, IPersistable
    {
        public String fileName { get; set; }

        public SiteKeys() { }
        public SiteKeys(String path) : base()
        { 
            this.fileName = Path.Combine(path,"cyapass.json");
        }
        public bool Save()
        {
            
            String allSitesAsJson = JsonConvert.SerializeObject(this);
            File.Delete(fileName);
            File.AppendAllText(fileName, allSitesAsJson);
            return true;
        }

        public SiteKey GetItemByKey(String key)
        {
            foreach (SiteKey s in this)
            {
                if (s.Key == key){
                    return s;
                }
            }
            return null;
        }
    }
}

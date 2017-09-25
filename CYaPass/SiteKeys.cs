using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CYaPass
{
    public class SiteKeys : List<SiteKey>, IPersistable
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

        public static SiteKey GetItemByKey(String key, SiteKeys allSites)
        {
            foreach (SiteKey s in allSites)
            {
                if (s.Key == key){
                    return s;
                }
            }
            return null;
        }
    }
}

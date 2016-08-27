using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DragPass
{
    class SiteKeys : List<SiteKey>, IPersistable
    {
        public String fileName { get; set; }
        public SiteKeys()
        {
            String exeDir = Directory.GetCurrentDirectory();
            fileName = Path.Combine(exeDir,"dragpass.json");
        }
        public bool Save()
        {
            
            String allSitesAsJson = JsonConvert.SerializeObject(this);
            File.Delete(fileName);
            File.AppendAllText(fileName, allSitesAsJson);
            return true;
        }
    }
}

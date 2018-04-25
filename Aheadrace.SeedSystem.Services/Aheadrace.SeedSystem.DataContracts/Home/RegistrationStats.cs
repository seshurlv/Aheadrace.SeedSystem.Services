using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.DataContracts.Home
{
    public class RegistrationStats
    {
        public string Month { get; set; }
        public int RegistrationCount { get; set; }
        public int InspectedCount { get; set; }
        public string DistrictName { get; set; }
        public int UserRegistrationCount { get; set; }
        public string Status { get; set; }     
        public int Count { get; set; }
    }

    public class CropsRegistered
    {
        public string CropName { get; set; }
        public int RegistrationCount { get; set; }
        public decimal CropArea { get; set; }
    }    
}

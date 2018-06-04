using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.DataContracts.Common
{
    public class Address : Common
    {
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public string PostalCode { get; set; }
        public Region Region { get; set; }
        public int AddressType { get; set; }
        public District District { get; set; }
        public EPA EPA { get; set; }
        public Section Section { get; set; }
    }

    public class Region : Common
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string RegionDescription { get; set; }
    }

    public class Country : Common
    {
        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryPhoneCode { get; set; }
    }

    public class State : Common
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
    }

    public class District : Common
    {
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string DistrictDescription { get; set; }
        public State State { get; set; }
    }

    public class EPA : Common
    {
        public int ID { get; set; }
        public string EPAName { get; set; }
        public string Description { get; set; }
        public District District { get; set; }
    }

    public class Section : Common
    {
        public int ID { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }
        public EPA EPA { get; set; }
    }
}

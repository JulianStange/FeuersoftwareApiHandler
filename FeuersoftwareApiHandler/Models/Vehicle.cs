using System;
using System.Collections.Generic;
using System.Text;

namespace FeuersoftwareApiHandler.Models
{
    public class Vehicle
    {
        public int? Id { get; set; }
        public string RadioId { get; set; }

        public string PlaceName { get; set; }

        public string OrganizationCallSign { get; set; }

        public int? LocationIdentificationNumber { get; set; }

        public string VehicleIdentifier { get; set; }

        public int? Subdivision { get; set; }

        public string Description { get; set; }

        public int? Crew { get; set; }

        public string Phone { get; set; }

        public Site Site;

        public string CallSign { get; set; }

        public VehicleStatus Status { get; set; }
    }
}

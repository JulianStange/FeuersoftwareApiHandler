using System;
using System.Collections.Generic;
using System.Text;

namespace FeuersoftwareApiHandler.Models
{
    public class CreateDefectReport
    {
        public int SiteId = 13757;
        public int Status = 0;
        public string ShortDescription;
        public string DetailedDescription;
        public int Priority = 0;
        public string ResponsibleUserId;
        public int VehicleId;
        public string ReporterId;
        public int Odometer;
        public int CategoryId;
        public int CategoryInformation = 6123;
    }
}

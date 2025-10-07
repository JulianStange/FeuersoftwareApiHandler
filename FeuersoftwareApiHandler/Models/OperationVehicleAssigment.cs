#nullable enable

using System;
using System.Collections.Generic;
using System.Text;

namespace FeuersoftwareApiHandler.Models
{
    public class OperationVehicleAssigment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Vehicle? Vehicle { get; set; }
    }
}

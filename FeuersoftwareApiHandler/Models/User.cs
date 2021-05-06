using System;
using System.Collections.Generic;
using System.Text;

namespace FeuersoftwareApiHandler.Models
{
    public class User
    {
        public AccountStatus AccountStatus;

        public AddressModel Address;

        public string PhoneNumber;

        public string LandlineNumber;

        public List<BluetoothBeacon> BluetoothBeacons;

        public List<Site> Sites;

        public string Id;

        public string FirstName;

        public string LastName;

        public string Email;

        public string UserName;

        public string PagerIssi;
    }
}

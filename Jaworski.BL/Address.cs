﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaworski.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int AddressID)
        {
            this.AddressID = AddressID;
        }

        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Address DownloadAdress(int AddressID)
        {
            // code to download AdressID data
            return new Address();
        }

    }
}

using System;
using FBC.WebApi.Enum;

namespace FBC.WebApi.Data {
    public class Address: DbEntity
    {
        public int AddressId;
        public string Address1;
        public string Address2;
        public string City;
        public string State;
        public int Zip;
        public AddressType Type;
    }
}
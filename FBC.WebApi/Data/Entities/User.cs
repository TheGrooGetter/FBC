using System;
using System.Collections;
using System.Collections.Generic;

namespace FBC.WebApi.Data {
    public class User: DbEntity {
        public string FirstName;
        public string LastName;
        public string UserName;
        public string Password;
        public string Email;
        public int UserId;
        public int PreferredPhone;
        public int PreferredAddress;
        public DateTime LastLogin;
        public int FailedAttempts;
        public List<Address> Addresses;
        public List<Phone> PhoneNumbers;
        public Cart ShoppingCart;
    }
}
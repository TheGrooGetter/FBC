using System;
using FBC.WebApi.Enum;

namespace FBC.WebApi.Data
{
    public class Phone: DbEntity
    {
        public int PhoneId;
        public int PhoneNum;
        public PhoneType Type;
    }
}
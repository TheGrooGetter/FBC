using System;
using System.Collections.Generic;
using FBC.WebApi.Enum;

namespace FBC.WebApi.Data
{
    public class Cart: DbEntity
    {
        public List<Item> Items;
        
    }
}
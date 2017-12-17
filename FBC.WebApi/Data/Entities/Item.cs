using System;
using System.Collections.Generic;
using FBC.WebApi.Enum;

namespace FBC.WebApi.Data
{
    public class Item: DbEntity
    {
        public int ItemId;
        public string Name;
        public string Description;
        public double Price;
        public ItemType Type;
        public int Quantity;
        public List<Modifier> Modifiers;
    }
}
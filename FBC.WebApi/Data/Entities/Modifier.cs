using System;
using FBC.WebApi.Enum;

namespace FBC.WebApi.Data
{
    public class Modifier: DbEntity
    {
        public string Name;
        public string Value;
        public string Description;
        public ModifierType Type;
    }
}
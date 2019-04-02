﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProperty : ISDMLProperty
    {
        public bool HasBody { get; }
        public string ObjectName { get; } = "Property";
        public string ElementName { get; set; }

        public void AddAttribute(ISDMLAttribute attribute)
        {
            throw new System.NotImplementedException();
        }

        public string GetTag()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => GetTag();
    }
}

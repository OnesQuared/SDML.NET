﻿namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLTypeAttribute : ISDMLTypeAttribute
    {
        public string ObjectName { get; } = "Type";
        public string Value { get; set; }
    }
}
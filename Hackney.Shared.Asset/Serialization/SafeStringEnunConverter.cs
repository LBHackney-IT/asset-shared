﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Hackney.Shared.Asset.Serialization
{
    // You must update this library in every project, otherwise you will not detect new enum values
    public class SafeStringEnumConverter : StringEnumConverter
    {
        public object DefaultValue { get; }

        public SafeStringEnumConverter(object defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch
            {
                return DefaultValue;
            }
        }
    }
}

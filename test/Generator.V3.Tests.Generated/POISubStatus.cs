// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Generator.V3.Tests.Generated
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum POISubStatus
    {
        [EnumMember(Value = "Available"), Display(Name = "Available", Description = "available"), SourceValue(Value = "Available")]
        Available,
        [EnumMember(Value = "Unavailable"), Display(Name = "Unavailable", Description = "unavailable"), SourceValue(Value = "Unavailable")]
        Unavailable
    }
}
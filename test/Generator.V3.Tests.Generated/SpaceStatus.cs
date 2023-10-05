// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Generator.V3.Tests.Generated
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SpaceStatus
    {
        [EnumMember(Value = "Active"), Display(Name = "Active", Description = "active"), SourceValue(Value = "Active")]
        Active,
        [EnumMember(Value = "Inactive"), Display(Name = "Inactive", Description = "inactive"), SourceValue(Value = "Inactive")]
        Inactive,
        [EnumMember(Value = "Pending"), Display(Name = "Pending", Description = "pending"), SourceValue(Value = "Pending")]
        Pending,
        [EnumMember(Value = "UnderConstruction"), Display(Name = "Under Construction", Description = "underConstruction"), SourceValue(Value = "UnderConstruction")]
        UnderConstruction
    }
}
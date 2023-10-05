// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Generator.V2.Tests.Generated
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BuildingHasAddressRelationshipAddressType
    {
        [EnumMember(Value = "Mailing"), Display(Name = "Mailing"), SourceValue(Value = "Mailing")]
        Mailing,
        [EnumMember(Value = "Street"), Display(Name = "Street"), SourceValue(Value = "Street")]
        Street,
        [EnumMember(Value = "Temporary"), Display(Name = "Temporary"), SourceValue(Value = "Temporary")]
        Temporary
    }
}
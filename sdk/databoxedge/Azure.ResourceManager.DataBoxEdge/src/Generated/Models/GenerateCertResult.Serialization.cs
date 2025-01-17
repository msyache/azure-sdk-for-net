// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class GenerateCertResult
    {
        internal static GenerateCertResult DeserializeGenerateCertResult(JsonElement element)
        {
            Optional<string> publicKey = default;
            Optional<string> privateKey = default;
            Optional<DateTimeOffset> expiryTimeInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKey"))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeInUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new GenerateCertResult(publicKey.Value, privateKey.Value, Optional.ToNullable(expiryTimeInUtc));
        }
    }
}

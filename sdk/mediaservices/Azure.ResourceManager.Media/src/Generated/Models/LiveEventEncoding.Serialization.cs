// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventEncoding : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EncodingType))
            {
                writer.WritePropertyName("encodingType");
                writer.WriteStringValue(EncodingType.Value.ToString());
            }
            if (Optional.IsDefined(PresetName))
            {
                writer.WritePropertyName("presetName");
                writer.WriteStringValue(PresetName);
            }
            if (Optional.IsDefined(StretchMode))
            {
                if (StretchMode != null)
                {
                    writer.WritePropertyName("stretchMode");
                    writer.WriteStringValue(StretchMode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("stretchMode");
                }
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                if (KeyFrameInterval != null)
                {
                    writer.WritePropertyName("keyFrameInterval");
                    writer.WriteStringValue(KeyFrameInterval.Value, "P");
                }
                else
                {
                    writer.WriteNull("keyFrameInterval");
                }
            }
            writer.WriteEndObject();
        }

        internal static LiveEventEncoding DeserializeLiveEventEncoding(JsonElement element)
        {
            Optional<LiveEventEncodingType> encodingType = default;
            Optional<string> presetName = default;
            Optional<InputVideoStretchMode?> stretchMode = default;
            Optional<TimeSpan?> keyFrameInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodingType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encodingType = new LiveEventEncodingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("presetName"))
                {
                    presetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stretchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stretchMode = null;
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyFrameInterval = null;
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new LiveEventEncoding(Optional.ToNullable(encodingType), presetName.Value, Optional.ToNullable(stretchMode), Optional.ToNullable(keyFrameInterval));
        }
    }
}

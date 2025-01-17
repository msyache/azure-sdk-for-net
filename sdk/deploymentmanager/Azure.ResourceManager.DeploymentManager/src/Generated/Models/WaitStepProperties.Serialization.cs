// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class WaitStepProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("attributes");
            writer.WriteObjectValue(Attributes);
            writer.WritePropertyName("stepType");
            writer.WriteStringValue(StepType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static WaitStepProperties DeserializeWaitStepProperties(JsonElement element)
        {
            WaitStepAttributes attributes = default;
            StepType stepType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attributes"))
                {
                    attributes = WaitStepAttributes.DeserializeWaitStepAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("stepType"))
                {
                    stepType = property.Value.GetString().ToStepType();
                    continue;
                }
            }
            return new WaitStepProperties(stepType, attributes);
        }
    }
}

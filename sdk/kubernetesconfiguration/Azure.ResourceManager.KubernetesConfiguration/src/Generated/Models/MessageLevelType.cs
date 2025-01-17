// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Level of the message. </summary>
    public readonly partial struct MessageLevelType : IEquatable<MessageLevelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageLevelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageLevelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string InformationValue = "Information";

        /// <summary> Error. </summary>
        public static MessageLevelType Error { get; } = new MessageLevelType(ErrorValue);
        /// <summary> Warning. </summary>
        public static MessageLevelType Warning { get; } = new MessageLevelType(WarningValue);
        /// <summary> Information. </summary>
        public static MessageLevelType Information { get; } = new MessageLevelType(InformationValue);
        /// <summary> Determines if two <see cref="MessageLevelType"/> values are the same. </summary>
        public static bool operator ==(MessageLevelType left, MessageLevelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageLevelType"/> values are not the same. </summary>
        public static bool operator !=(MessageLevelType left, MessageLevelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageLevelType"/>. </summary>
        public static implicit operator MessageLevelType(string value) => new MessageLevelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageLevelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageLevelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

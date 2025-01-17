// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SKU restriction type. </summary>
    public readonly partial struct SkuRestrictionType : IEquatable<SkuRestrictionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuRestrictionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuRestrictionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string LocationValue = "Location";
        private const string ZoneValue = "Zone";

        /// <summary> NotSpecified. </summary>
        public static SkuRestrictionType NotSpecified { get; } = new SkuRestrictionType(NotSpecifiedValue);
        /// <summary> Location. </summary>
        public static SkuRestrictionType Location { get; } = new SkuRestrictionType(LocationValue);
        /// <summary> Zone. </summary>
        public static SkuRestrictionType Zone { get; } = new SkuRestrictionType(ZoneValue);
        /// <summary> Determines if two <see cref="SkuRestrictionType"/> values are the same. </summary>
        public static bool operator ==(SkuRestrictionType left, SkuRestrictionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuRestrictionType"/> values are not the same. </summary>
        public static bool operator !=(SkuRestrictionType left, SkuRestrictionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuRestrictionType"/>. </summary>
        public static implicit operator SkuRestrictionType(string value) => new SkuRestrictionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuRestrictionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuRestrictionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

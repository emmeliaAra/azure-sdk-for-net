// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Indicates whether the file was deleted from the storage account. </summary>
    public readonly partial struct SecurityInsightsFileDeleteStatus : IEquatable<SecurityInsightsFileDeleteStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileDeleteStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsFileDeleteStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletedValue = "Deleted";
        private const string NotDeletedValue = "NotDeleted";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary> The file was deleted. </summary>
        public static SecurityInsightsFileDeleteStatus Deleted { get; } = new SecurityInsightsFileDeleteStatus(DeletedValue);
        /// <summary> The file was not deleted. </summary>
        public static SecurityInsightsFileDeleteStatus NotDeleted { get; } = new SecurityInsightsFileDeleteStatus(NotDeletedValue);
        /// <summary> Unspecified. </summary>
        public static SecurityInsightsFileDeleteStatus Unspecified { get; } = new SecurityInsightsFileDeleteStatus(UnspecifiedValue);
        /// <summary> Determines if two <see cref="SecurityInsightsFileDeleteStatus"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsFileDeleteStatus left, SecurityInsightsFileDeleteStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsFileDeleteStatus"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsFileDeleteStatus left, SecurityInsightsFileDeleteStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsFileDeleteStatus"/>. </summary>
        public static implicit operator SecurityInsightsFileDeleteStatus(string value) => new SecurityInsightsFileDeleteStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsFileDeleteStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsFileDeleteStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

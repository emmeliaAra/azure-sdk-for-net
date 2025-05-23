// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Failover direction. </summary>
    public readonly partial struct RecoveryServicesSiteRecoveryFailoverDirection : IEquatable<RecoveryServicesSiteRecoveryFailoverDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesSiteRecoveryFailoverDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecoveryServicesSiteRecoveryFailoverDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryToRecoveryValue = "PrimaryToRecovery";
        private const string RecoveryToPrimaryValue = "RecoveryToPrimary";

        /// <summary> PrimaryToRecovery. </summary>
        public static RecoveryServicesSiteRecoveryFailoverDirection PrimaryToRecovery { get; } = new RecoveryServicesSiteRecoveryFailoverDirection(PrimaryToRecoveryValue);
        /// <summary> RecoveryToPrimary. </summary>
        public static RecoveryServicesSiteRecoveryFailoverDirection RecoveryToPrimary { get; } = new RecoveryServicesSiteRecoveryFailoverDirection(RecoveryToPrimaryValue);
        /// <summary> Determines if two <see cref="RecoveryServicesSiteRecoveryFailoverDirection"/> values are the same. </summary>
        public static bool operator ==(RecoveryServicesSiteRecoveryFailoverDirection left, RecoveryServicesSiteRecoveryFailoverDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecoveryServicesSiteRecoveryFailoverDirection"/> values are not the same. </summary>
        public static bool operator !=(RecoveryServicesSiteRecoveryFailoverDirection left, RecoveryServicesSiteRecoveryFailoverDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RecoveryServicesSiteRecoveryFailoverDirection"/>. </summary>
        public static implicit operator RecoveryServicesSiteRecoveryFailoverDirection(string value) => new RecoveryServicesSiteRecoveryFailoverDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecoveryServicesSiteRecoveryFailoverDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecoveryServicesSiteRecoveryFailoverDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

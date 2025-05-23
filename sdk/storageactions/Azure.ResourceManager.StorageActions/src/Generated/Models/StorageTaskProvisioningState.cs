// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageActions.Models
{
    /// <summary> Represents the provisioning state of the storage task. </summary>
    public readonly partial struct StorageTaskProvisioningState : IEquatable<StorageTaskProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageTaskProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageTaskProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidateSubscriptionQuotaBeginValue = "ValidateSubscriptionQuotaBegin";
        private const string ValidateSubscriptionQuotaEndValue = "ValidateSubscriptionQuotaEnd";
        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> ValidateSubscriptionQuotaBegin. </summary>
        public static StorageTaskProvisioningState ValidateSubscriptionQuotaBegin { get; } = new StorageTaskProvisioningState(ValidateSubscriptionQuotaBeginValue);
        /// <summary> ValidateSubscriptionQuotaEnd. </summary>
        public static StorageTaskProvisioningState ValidateSubscriptionQuotaEnd { get; } = new StorageTaskProvisioningState(ValidateSubscriptionQuotaEndValue);
        /// <summary> Accepted. </summary>
        public static StorageTaskProvisioningState Accepted { get; } = new StorageTaskProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static StorageTaskProvisioningState Creating { get; } = new StorageTaskProvisioningState(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static StorageTaskProvisioningState Succeeded { get; } = new StorageTaskProvisioningState(SucceededValue);
        /// <summary> Deleting. </summary>
        public static StorageTaskProvisioningState Deleting { get; } = new StorageTaskProvisioningState(DeletingValue);
        /// <summary> Canceled. </summary>
        public static StorageTaskProvisioningState Canceled { get; } = new StorageTaskProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static StorageTaskProvisioningState Failed { get; } = new StorageTaskProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="StorageTaskProvisioningState"/> values are the same. </summary>
        public static bool operator ==(StorageTaskProvisioningState left, StorageTaskProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageTaskProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(StorageTaskProvisioningState left, StorageTaskProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageTaskProvisioningState"/>. </summary>
        public static implicit operator StorageTaskProvisioningState(string value) => new StorageTaskProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageTaskProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageTaskProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

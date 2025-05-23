// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Provisioning state of managed instance. </summary>
    public readonly partial struct ManagedInstancePropertiesProvisioningState : IEquatable<ManagedInstancePropertiesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePropertiesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedInstancePropertiesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedValue = "Created";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string UnknownValue = "Unknown";
        private const string AcceptedValue = "Accepted";
        private const string DeletedValue = "Deleted";
        private const string UnrecognizedValue = "Unrecognized";
        private const string RunningValue = "Running";
        private const string NotSpecifiedValue = "NotSpecified";
        private const string RegisteringValue = "Registering";
        private const string TimedOutValue = "TimedOut";

        /// <summary> Created. </summary>
        public static ManagedInstancePropertiesProvisioningState Created { get; } = new ManagedInstancePropertiesProvisioningState(CreatedValue);
        /// <summary> InProgress. </summary>
        public static ManagedInstancePropertiesProvisioningState InProgress { get; } = new ManagedInstancePropertiesProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static ManagedInstancePropertiesProvisioningState Succeeded { get; } = new ManagedInstancePropertiesProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ManagedInstancePropertiesProvisioningState Failed { get; } = new ManagedInstancePropertiesProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ManagedInstancePropertiesProvisioningState Canceled { get; } = new ManagedInstancePropertiesProvisioningState(CanceledValue);
        /// <summary> Creating. </summary>
        public static ManagedInstancePropertiesProvisioningState Creating { get; } = new ManagedInstancePropertiesProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static ManagedInstancePropertiesProvisioningState Deleting { get; } = new ManagedInstancePropertiesProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static ManagedInstancePropertiesProvisioningState Updating { get; } = new ManagedInstancePropertiesProvisioningState(UpdatingValue);
        /// <summary> Unknown. </summary>
        public static ManagedInstancePropertiesProvisioningState Unknown { get; } = new ManagedInstancePropertiesProvisioningState(UnknownValue);
        /// <summary> Accepted. </summary>
        public static ManagedInstancePropertiesProvisioningState Accepted { get; } = new ManagedInstancePropertiesProvisioningState(AcceptedValue);
        /// <summary> Deleted. </summary>
        public static ManagedInstancePropertiesProvisioningState Deleted { get; } = new ManagedInstancePropertiesProvisioningState(DeletedValue);
        /// <summary> Unrecognized. </summary>
        public static ManagedInstancePropertiesProvisioningState Unrecognized { get; } = new ManagedInstancePropertiesProvisioningState(UnrecognizedValue);
        /// <summary> Running. </summary>
        public static ManagedInstancePropertiesProvisioningState Running { get; } = new ManagedInstancePropertiesProvisioningState(RunningValue);
        /// <summary> NotSpecified. </summary>
        public static ManagedInstancePropertiesProvisioningState NotSpecified { get; } = new ManagedInstancePropertiesProvisioningState(NotSpecifiedValue);
        /// <summary> Registering. </summary>
        public static ManagedInstancePropertiesProvisioningState Registering { get; } = new ManagedInstancePropertiesProvisioningState(RegisteringValue);
        /// <summary> TimedOut. </summary>
        public static ManagedInstancePropertiesProvisioningState TimedOut { get; } = new ManagedInstancePropertiesProvisioningState(TimedOutValue);
        /// <summary> Determines if two <see cref="ManagedInstancePropertiesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ManagedInstancePropertiesProvisioningState left, ManagedInstancePropertiesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedInstancePropertiesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ManagedInstancePropertiesProvisioningState left, ManagedInstancePropertiesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedInstancePropertiesProvisioningState"/>. </summary>
        public static implicit operator ManagedInstancePropertiesProvisioningState(string value) => new ManagedInstancePropertiesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedInstancePropertiesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedInstancePropertiesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The receiver type. </summary>
    public readonly partial struct PipelineGroupReceiverType : IEquatable<PipelineGroupReceiverType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PipelineGroupReceiverType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PipelineGroupReceiverType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SyslogValue = "Syslog";
        private const string AmaValue = "Ama";
        private const string PipelineGroupValue = "PipelineGroup";
        private const string OtlpValue = "OTLP";
        private const string UdpValue = "UDP";

        /// <summary> Linux syslog. </summary>
        public static PipelineGroupReceiverType Syslog { get; } = new PipelineGroupReceiverType(SyslogValue);
        /// <summary> Receives data from azure monitor agent receiver. </summary>
        public static PipelineGroupReceiverType Ama { get; } = new PipelineGroupReceiverType(AmaValue);
        /// <summary> Receives data from another pipeline group. </summary>
        public static PipelineGroupReceiverType PipelineGroup { get; } = new PipelineGroupReceiverType(PipelineGroupValue);
        /// <summary> Receives data from a OTLP collector. </summary>
        public static PipelineGroupReceiverType Otlp { get; } = new PipelineGroupReceiverType(OtlpValue);
        /// <summary> Receives data from an UDP collector. </summary>
        public static PipelineGroupReceiverType Udp { get; } = new PipelineGroupReceiverType(UdpValue);
        /// <summary> Determines if two <see cref="PipelineGroupReceiverType"/> values are the same. </summary>
        public static bool operator ==(PipelineGroupReceiverType left, PipelineGroupReceiverType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PipelineGroupReceiverType"/> values are not the same. </summary>
        public static bool operator !=(PipelineGroupReceiverType left, PipelineGroupReceiverType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PipelineGroupReceiverType"/>. </summary>
        public static implicit operator PipelineGroupReceiverType(string value) => new PipelineGroupReceiverType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PipelineGroupReceiverType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PipelineGroupReceiverType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

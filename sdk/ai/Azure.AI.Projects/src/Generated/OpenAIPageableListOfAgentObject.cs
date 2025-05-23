// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> The OpenAIPageableListOfAgentObject. </summary>
    internal readonly partial struct OpenAIPageableListOfAgentObject : IEquatable<OpenAIPageableListOfAgentObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OpenAIPageableListOfAgentObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OpenAIPageableListOfAgentObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static OpenAIPageableListOfAgentObject List { get; } = new OpenAIPageableListOfAgentObject(ListValue);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfAgentObject"/> values are the same. </summary>
        public static bool operator ==(OpenAIPageableListOfAgentObject left, OpenAIPageableListOfAgentObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfAgentObject"/> values are not the same. </summary>
        public static bool operator !=(OpenAIPageableListOfAgentObject left, OpenAIPageableListOfAgentObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OpenAIPageableListOfAgentObject"/>. </summary>
        public static implicit operator OpenAIPageableListOfAgentObject(string value) => new OpenAIPageableListOfAgentObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OpenAIPageableListOfAgentObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OpenAIPageableListOfAgentObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

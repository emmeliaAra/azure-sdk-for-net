// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> The message template's text value information. </summary>
    public partial class MessageTemplateText : MessageTemplateValue
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateText"/>. </summary>
        /// <param name="name"> Template binding reference name. </param>
        /// <param name="text"> The text value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="text"/> is null. </exception>
        public MessageTemplateText(string name, string text) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(text, nameof(text));

            Kind = MessageTemplateValueKind.Text;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateText"/>. </summary>
        /// <param name="name"> Template binding reference name. </param>
        /// <param name="kind"> The type discriminator describing a template parameter type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="text"> The text value. </param>
        internal MessageTemplateText(string name, MessageTemplateValueKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string text) : base(name, kind, serializedAdditionalRawData)
        {
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateText"/> for deserialization. </summary>
        internal MessageTemplateText()
        {
        }

        /// <summary> The text value. </summary>
        public string Text { get; set; }
    }
}

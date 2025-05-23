// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace _Type.Scalar
{
    public partial class DecimalVerify
    {
        protected DecimalVerify() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response PrepareVerify(RequestContext context) => throw null;

        public virtual Task<Response> PrepareVerifyAsync(RequestContext context) => throw null;

        public virtual Response<IReadOnlyList<decimal>> PrepareVerify(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<IReadOnlyList<decimal>>> PrepareVerifyAsync(CancellationToken cancellationToken = default) => throw null;

        public virtual Response Verify(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> VerifyAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response Verify(decimal body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> VerifyAsync(decimal body, CancellationToken cancellationToken = default) => throw null;
    }
}

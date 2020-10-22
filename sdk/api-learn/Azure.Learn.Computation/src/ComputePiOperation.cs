// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation
{
    /// <inheritdoc />
    public class ComputePiOperation : Operation<ComputePiProgress>
    {
        /// <inheritdoc/>
        public override Response GetRawResponse()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override ValueTask<Response<ComputePiProgress>> WaitForCompletionAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override ValueTask<Response<ComputePiProgress>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Response UpdateStatus(CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string Id { get; }

        /// <inheritdoc/>
        public override ComputePiProgress Value { get; }

        /// <inheritdoc/>
        public override bool HasCompleted { get; }

        /// <inheritdoc/>
        public override bool HasValue { get; }
    }
}

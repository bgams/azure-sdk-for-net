// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// Compute node model
    /// </summary>
    [CodeGenModel("ComputeNode")]
    public partial class ComputeNode
    {
        /// <summary>
        /// Etag
        /// </summary>
        [CodeGenMember("Etag")]
        public ETag ETag { get; }
    }
}

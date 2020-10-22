// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Learn.Computation.Models
{
    /// <summary>
    /// Linux compute node
    /// </summary>

    [CodeGenModel("LinuxComputeNode")]
    public partial class LinuxComputeNode
    {
        /// <summary>
        /// Ssh public key
        /// </summary>
        [CodeGenMember("SshPublicKey")]
        public string SshPublicKey { get; }
    }
}

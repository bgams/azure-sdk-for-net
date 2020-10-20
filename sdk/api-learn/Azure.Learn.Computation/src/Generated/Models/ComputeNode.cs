// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.Learn.Computation
{
    /// <summary> The ComputeNode. </summary>
    public partial class ComputeNode
    {
        /// <summary> Initializes a new instance of ComputeNode. </summary>
        /// <param name="name"> The name of the compute node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ComputeNode(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of ComputeNode. </summary>
        /// <param name="eTag"> An HTTP ETag. </param>
        /// <param name="name"> The name of the compute node. </param>
        /// <param name="kind"> . </param>
        internal ComputeNode(ETag eTag, string name, string kind)
        {
            ETag = eTag;
            Name = name;
            Kind = kind;
        }
        /// <summary> The name of the compute node. </summary>
        public string Name { get; }
        internal string Kind { get; set; }
    }
}

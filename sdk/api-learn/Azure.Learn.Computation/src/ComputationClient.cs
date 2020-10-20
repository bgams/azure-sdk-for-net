// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// Compute node type
    /// </summary>
    public enum ComputeNodeType
    {
        /// <summary>
        /// Windows node
        /// </summary>
        Windows,

        /// <summary>
        /// Linux Node
        /// </summary>
        Linux
    }

    /// <summary>
    /// Computation client
    /// </summary>
    public class ComputationClient
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="endpoint">The endpoint client connects to.</param>
        /// <param name="credential">The credential client uses to connect to endpoint</param>
        public ComputationClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ComputationClientOptions())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ComputationClient"/>.</summary>
#pragma warning disable CA1801 // Parameter is never used
        public ComputationClient(Uri endpoint, TokenCredential credential, ComputationClientOptions options)
        {
        }
#pragma warning restore CA1801 // Parameter is never used

        /// <summary> Initializes a new instance of ConfigurationClient for mocking. </summary>
        protected ComputationClient()
        {
        }

        /// <summary>
        /// Create a compute node
        /// </summary>
        /// <param name="name">name of the node</param>
        /// <param name="nodeType">type of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Created <see cref="ComputeNode"/></returns>
        public virtual Response<ComputeNode> CreateComputeNode(string name, ComputeNodeType nodeType = ComputeNodeType.Windows, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a compute node
        /// </summary>
        /// <param name="name">name of the node</param>
        /// <param name="nodeType">type of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Created <see cref="ComputeNode"/></returns>
        public virtual async Task<Response<ComputeNode>> CreateComputeNodeAsync(string name, ComputeNodeType nodeType = ComputeNodeType.Windows, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a compute node
        /// </summary>
        /// <param name="name">name of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Returned <see cref="ComputeNode"/></returns>
        public virtual Response<ComputeNode> GetComputeNode(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a compute node
        /// </summary>
        /// <param name="name">name of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Returned <see cref="ComputeNode"/></returns>
        public virtual async Task<Response<ComputeNode>> GetComputeNodeAsync(string name, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all compute nodes
        /// </summary>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>List of <see cref="ComputeNode"/></returns>
        public virtual Pageable<ComputeNode> GetComputeNodes(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all compute nodes
        /// </summary>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>List of <see cref="ComputeNode"/></returns>
        public virtual AsyncPageable<ComputeNode> GetComputeNodesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start a computation
        /// </summary>
        /// <param name="name">Name of the node to use</param>
        /// <param name="precision">Precision of pi</param>
        /// <param name="createIfNotExist">Create the node if it doesn't exist</param>
        /// <param name="createIfNotExistNodeType">Node type to use if we create the node on the fly</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual Response<ComputationOperation> StartComputation(string name, int? precision = null, bool createIfNotExist = false, ComputeNodeType createIfNotExistNodeType = ComputeNodeType.Windows, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start a computation
        /// </summary>
        /// <param name="name">Name of the node to use</param>
        /// <param name="precision">Precision of pi</param>
        /// <param name="createIfNotExist">Create the node if it doesn't exist</param>
        /// <param name="createIfNotExistNodeType">Node type to use if we create the node on the fly</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual async Task<Response<ComputationOperation>> StartComputationAsync(string name, int? precision = null, bool createIfNotExist = false, ComputeNodeType createIfNotExistNodeType = ComputeNodeType.Windows, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }
}

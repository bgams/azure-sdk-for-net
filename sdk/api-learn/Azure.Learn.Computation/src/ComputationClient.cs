// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// Computation client
    /// </summary>
    public class ComputationClient
    {
        private HttpPipeline _pipeline;
        private ClientDiagnostics _clientDiagnostics;
        private Uri _endpoint;

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
            //Argument.AssertNotNull(endpoint, nameof(endpoint));
            //Argument.AssertNotNull(endpoint, nameof(endpoint));
            //Argument.AssertNotNull(endpoint, nameof(endpoint));

            _pipeline = HttpPipelineBuilder.Build(options);
            _clientDiagnostics = new ClientDiagnostics(options);
            _endpoint = endpoint;

        }
#pragma warning restore CA1801 // Parameter is never used

        /// <summary> Initializes a new instance of ConfigurationClient for mocking. </summary>
        protected ComputationClient()
        {
        }

        /// <summary>
        /// Create a compute node
        /// </summary>
        /// <param name="node">Node to create</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Created <see cref="ComputeNode"/></returns>
        public virtual Response<ComputeNode> CreateComputeNode(ComputeNode node, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a compute node
        /// </summary>
        /// <param name="node">Node to create</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Created <see cref="ComputeNode"/></returns>
        public virtual async Task<Response<ComputeNode>> CreateComputeNodeAsync(ComputeNode node, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a compute node
        /// </summary>
        /// <param name="nodeName">name of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Returned <see cref="ComputeNode"/></returns>
        public virtual Response<ComputeNode> GetComputeNode(string nodeName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a compute node
        /// </summary>
        /// <param name="nodeName">name of the node</param>
        /// <param name="cancellationToken">token to cancel operation</param>
        /// <returns>Returned <see cref="ComputeNode"/></returns>
        public virtual async Task<Response<ComputeNode>> GetComputeNodeAsync(string nodeName, CancellationToken cancellationToken = default)
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
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual ComputePiOperation StartComputePi(string name, int? precision = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start a computation
        /// </summary>
        /// <param name="name">Name of the node to use</param>
        /// <param name="precision">Precision of pi</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual async Task<ComputePiOperation> StartComputePiAsync(string name, int? precision = null, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start a computation with new node
        /// </summary>
        /// <param name="nodeToCreate">Node to create</param>
        /// <param name="precision">Precision of pi</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual ComputePiOperation StartComputePiWithNewNode(ComputeNode nodeToCreate, int? precision = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start a computation with new node
        /// </summary>
        /// <param name="nodeToCreate">Node to create</param>
        /// <param name="precision">Precision of pi</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>Long running computation operation</returns>
        public virtual async Task<ComputePiOperation> StartComputePiWithNewNodeAsync(ComputeNode nodeToCreate, int? precision = null, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }
}

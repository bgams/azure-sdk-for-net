// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation
{
    internal partial class ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateComputationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="operationId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<ResponseWithHeaders<ComputePiProgress, ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitComputationHeaders>> ComputationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateComputationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitComputationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComputePiProgress value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ComputePiProgress.DeserializeComputePiProgress(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="operationId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public ResponseWithHeaders<ComputePiProgress, ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitComputationHeaders> Computation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateComputationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            var headers = new ExampleComputationServiceForAzureSDKAPIDesignTrainingUnitComputationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComputePiProgress value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ComputePiProgress.DeserializeComputePiProgress(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

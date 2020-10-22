// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Learn.Computation.Samples;

namespace Azure.Learn.Computation.Tests.Samples
{
    public class Sample2_ComputationOperation : SamplesBase<LearnComputationTestEnvironment>
    {
        public async Task PerformComputation()
        {
            string endpoint = "http://example.azcompute.io";
            ComputationClient client = new ComputationClient(new Uri(endpoint), new DefaultAzureCredential());

            var operation = client.StartComputePi("linuxNode", 18);

            Console.WriteLine($"Operation started on {operation.Value.CreatedDateTime}");

            while (!operation.HasCompleted)
            {
                await operation.UpdateStatusAsync();
                Console.WriteLine($"{operation.Value.PercentComplete}% completed");
                await Task.Delay(100);
            }

            Console.WriteLine($"Pi={operation.Value.Value}");
        }
    }
}

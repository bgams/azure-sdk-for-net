// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Identity;

namespace Azure.Learn.Computation.Samples
{
    public class Sample1_HelloWorld : SamplesBase<LearnComputationTestEnvironment>
    {
        public void CreateComputeNode()
        {
            string endpoint = "http://example.azconfig.io";
            ComputationClient client = new ComputationClient(new Uri(endpoint), new DefaultAzureCredential());
            var response = client.CreateComputeNode("testWindowsNode");

            Console.WriteLine(response.Value.Name);
        }
    }
}

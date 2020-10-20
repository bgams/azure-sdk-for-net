// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation.Samples
{
    public class Sample1_HelloWorld : SamplesBase<LearnComputationTestEnvironment>
    {
        public void CreateComputeNode()
        {
            string endpoint = "http://example.azcompute.io";
            ComputationClient client = new ComputationClient(new Uri(endpoint), new DefaultAzureCredential());
            var response = client.CreateComputeNode(new WindowsComputeNode("testNode", "admin"));

            Console.WriteLine(response.Value.Name);
        }
    }
}

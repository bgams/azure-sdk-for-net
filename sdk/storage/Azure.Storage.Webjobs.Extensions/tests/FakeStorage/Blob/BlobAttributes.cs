﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace FakeStorage
{
    internal struct BlobAttributes
    {
        private readonly string _eTag;
        private readonly DateTimeOffset _lastModified;
        private readonly IReadOnlyDictionary<string, string> _metadata;

        public BlobAttributes(string eTag, DateTimeOffset lastModified, IReadOnlyDictionary<string, string> metadata)
        {
            _eTag = eTag;
            _lastModified = lastModified;
            _metadata = metadata;
        }

        public string ETag
        {
            get { return _eTag; }
        }

        public IReadOnlyDictionary<string, string> Metadata
        {
            get { return _metadata; }
        }

        public DateTimeOffset LastModified
        {
            get { return _lastModified; }
        }
    }
}

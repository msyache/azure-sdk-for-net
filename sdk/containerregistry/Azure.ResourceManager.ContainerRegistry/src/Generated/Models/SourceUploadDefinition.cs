// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a response to source upload request. </summary>
    public partial class SourceUploadDefinition
    {
        /// <summary> Initializes a new instance of SourceUploadDefinition. </summary>
        internal SourceUploadDefinition()
        {
        }

        /// <summary> Initializes a new instance of SourceUploadDefinition. </summary>
        /// <param name="uploadUri"> The URL where the client can upload the source. </param>
        /// <param name="relativePath"> The relative path to the source. This is used to submit the subsequent queue build request. </param>
        internal SourceUploadDefinition(Uri uploadUri, string relativePath)
        {
            UploadUri = uploadUri;
            RelativePath = relativePath;
        }

        /// <summary> The URL where the client can upload the source. </summary>
        public Uri UploadUri { get; }
        /// <summary> The relative path to the source. This is used to submit the subsequent queue build request. </summary>
        public string RelativePath { get; }
    }
}

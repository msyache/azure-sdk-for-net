// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The abstract base class for entity resolutions. </summary>
    internal partial class BaseResolution
    {
        /// <summary> Initializes a new instance of BaseResolution. </summary>
        public BaseResolution()
        {
        }

        /// <summary> Initializes a new instance of BaseResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        internal BaseResolution(ResolutionKind resolutionKind)
        {
            ResolutionKind = resolutionKind;
        }

        /// <summary> The entity resolution object kind. </summary>
        internal ResolutionKind ResolutionKind { get; set; }
    }
}

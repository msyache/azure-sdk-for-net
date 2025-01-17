// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of server auditing settings. </summary>
    internal partial class ServerBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of ServerBlobAuditingPolicyListResult. </summary>
        internal ServerBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<SqlServerBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of ServerBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerBlobAuditingPolicyListResult(IReadOnlyList<SqlServerBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}

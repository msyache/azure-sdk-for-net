// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTestService
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.LoadTestService. </summary>
    public static partial class LoadTestServiceExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of QuotaResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <returns> An object representing collection of QuotaResources and their operations over a QuotaResource. </returns>
        public static QuotaResourceCollection GetQuotaResources(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            return GetExtensionClient(subscriptionResource).GetQuotaResources(location);
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}
        /// Operation Id: Quotas_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<QuotaResource>> GetQuotaResourceAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaBucketName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetQuotaResources(location).GetAsync(quotaBucketName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}
        /// Operation Id: Quotas_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<QuotaResource> GetQuotaResource(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaBucketName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetQuotaResources(location).Get(quotaBucketName, cancellationToken);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests
        /// Operation Id: LoadTests_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadTestResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LoadTestResource> GetLoadTestResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLoadTestResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests
        /// Operation Id: LoadTests_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadTestResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LoadTestResource> GetLoadTestResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLoadTestResources(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of LoadTestResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of LoadTestResources and their operations over a LoadTestResource. </returns>
        public static LoadTestResourceCollection GetLoadTestResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetLoadTestResources();
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LoadTestResource>> GetLoadTestResourceAsync(this ResourceGroupResource resourceGroupResource, string loadTestName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetLoadTestResources().GetAsync(loadTestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<LoadTestResource> GetLoadTestResource(this ResourceGroupResource resourceGroupResource, string loadTestName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetLoadTestResources().Get(loadTestName, cancellationToken);
        }

        #region QuotaResource
        /// <summary>
        /// Gets an object representing a <see cref="QuotaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuotaResource.CreateResourceIdentifier" /> to create a <see cref="QuotaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QuotaResource" /> object. </returns>
        public static QuotaResource GetQuotaResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                QuotaResource.ValidateResourceId(id);
                return new QuotaResource(client, id);
            }
            );
        }
        #endregion

        #region LoadTestResource
        /// <summary>
        /// Gets an object representing a <see cref="LoadTestResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LoadTestResource.CreateResourceIdentifier" /> to create a <see cref="LoadTestResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LoadTestResource" /> object. </returns>
        public static LoadTestResource GetLoadTestResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LoadTestResource.ValidateResourceId(id);
                return new LoadTestResource(client, id);
            }
            );
        }
        #endregion
    }
}

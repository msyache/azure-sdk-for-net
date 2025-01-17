// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _cognitiveServicesAccountAccountsClientDiagnostics;
        private AccountsRestOperations _cognitiveServicesAccountAccountsRestClient;
        private ClientDiagnostics _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics;
        private DeletedAccountsRestOperations _cognitiveServicesDeletedAccountDeletedAccountsRestClient;
        private ClientDiagnostics _resourceSkusClientDiagnostics;
        private ResourceSkusRestOperations _resourceSkusRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private CognitiveServicesManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _commitmentTiersClientDiagnostics;
        private CommitmentTiersRestOperations _commitmentTiersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CognitiveServicesAccountAccountsClientDiagnostics => _cognitiveServicesAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations CognitiveServicesAccountAccountsRestClient => _cognitiveServicesAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CognitiveServicesAccountResource.ResourceType));
        private ClientDiagnostics CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics => _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesDeletedAccountResource.ResourceType.Namespace, Diagnostics);
        private DeletedAccountsRestOperations CognitiveServicesDeletedAccountDeletedAccountsRestClient => _cognitiveServicesDeletedAccountDeletedAccountsRestClient ??= new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CognitiveServicesDeletedAccountResource.ResourceType));
        private ClientDiagnostics ResourceSkusClientDiagnostics => _resourceSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceSkusRestOperations ResourceSkusRestClient => _resourceSkusRestClient ??= new ResourceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CognitiveServicesManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CognitiveServicesManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CommitmentTiersClientDiagnostics => _commitmentTiersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CommitmentTiersRestOperations CommitmentTiersRestClient => _commitmentTiersRestClient ??= new CommitmentTiersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CognitiveServicesDeletedAccountResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of CognitiveServicesDeletedAccountResources and their operations over a CognitiveServicesDeletedAccountResource. </returns>
        public virtual CognitiveServicesDeletedAccountCollection GetCognitiveServicesDeletedAccounts()
        {
            return GetCachedClient(Client => new CognitiveServicesDeletedAccountCollection(Client, Id));
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesAccountResource> GetCognitiveServicesAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CognitiveServicesAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CognitiveServicesAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts");
                scope.Start();
                try
                {
                    var response = await CognitiveServicesAccountAccountsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CognitiveServicesAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CognitiveServicesAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts");
                scope.Start();
                try
                {
                    var response = await CognitiveServicesAccountAccountsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesAccountResource> GetCognitiveServicesAccounts(CancellationToken cancellationToken = default)
        {
            Page<CognitiveServicesAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CognitiveServicesAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts");
                scope.Start();
                try
                {
                    var response = CognitiveServicesAccountAccountsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CognitiveServicesAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CognitiveServicesAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts");
                scope.Start();
                try
                {
                    var response = CognitiveServicesAccountAccountsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesDeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesDeletedAccountResource> GetDeletedAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CognitiveServicesDeletedAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = await CognitiveServicesDeletedAccountDeletedAccountsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesDeletedAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CognitiveServicesDeletedAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = await CognitiveServicesDeletedAccountDeletedAccountsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesDeletedAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesDeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesDeletedAccountResource> GetDeletedAccounts(CancellationToken cancellationToken = default)
        {
            Page<CognitiveServicesDeletedAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = CognitiveServicesDeletedAccountDeletedAccountsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesDeletedAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CognitiveServicesDeletedAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = CognitiveServicesDeletedAccountDeletedAccountsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CognitiveServicesDeletedAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Microsoft.CognitiveServices SKUs available for your Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCognitiveServicesSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableCognitiveServicesSku> GetResourceSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailableCognitiveServicesSku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceSkus");
                scope.Start();
                try
                {
                    var response = await ResourceSkusRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailableCognitiveServicesSku>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceSkus");
                scope.Start();
                try
                {
                    var response = await ResourceSkusRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Microsoft.CognitiveServices SKUs available for your Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCognitiveServicesSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableCognitiveServicesSku> GetResourceSkus(CancellationToken cancellationToken = default)
        {
            Page<AvailableCognitiveServicesSku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceSkus");
                scope.Start();
                try
                {
                    var response = ResourceSkusRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailableCognitiveServicesSku> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceSkus");
                scope.Start();
                try
                {
                    var response = ResourceSkusRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Check available SKUs.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/checkSkuAvailability
        /// Operation Id: CheckSkuAvailability
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="content"> Check SKU Availability POST body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesSkuAvailabilityList" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesSkuAvailabilityList> CheckSkuAvailabilityAsync(AzureLocation location, CognitiveServicesSkuAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            async Task<Page<CognitiveServicesSkuAvailabilityList>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSkuAvailability");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.CheckSkuAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Check available SKUs.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/checkSkuAvailability
        /// Operation Id: CheckSkuAvailability
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="content"> Check SKU Availability POST body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesSkuAvailabilityList" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesSkuAvailabilityList> CheckSkuAvailability(AzureLocation location, CognitiveServicesSkuAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Page<CognitiveServicesSkuAvailabilityList> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSkuAvailability");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.CheckSkuAvailability(Id.SubscriptionId, location, content, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Check whether a domain is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/checkDomainAvailability
        /// Operation Id: CheckDomainAvailability
        /// </summary>
        /// <param name="content"> Check Domain Availability parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CognitiveServicesDomainAvailabilityList>> CheckDomainAvailabilityAsync(CognitiveServicesDomainAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDomainAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckDomainAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check whether a domain is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/checkDomainAvailability
        /// Operation Id: CheckDomainAvailability
        /// </summary>
        /// <param name="content"> Check Domain Availability parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CognitiveServicesDomainAvailabilityList> CheckDomainAvailability(CognitiveServicesDomainAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDomainAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckDomainAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Commitment Tiers.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/commitmentTiers
        /// Operation Id: CommitmentTiers_List
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommitmentTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommitmentTier> GetCommitmentTiersAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            async Task<Page<CommitmentTier>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CommitmentTiersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCommitmentTiers");
                scope.Start();
                try
                {
                    var response = await CommitmentTiersRestClient.ListAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommitmentTier>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CommitmentTiersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCommitmentTiers");
                scope.Start();
                try
                {
                    var response = await CommitmentTiersRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List Commitment Tiers.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/commitmentTiers
        /// Operation Id: CommitmentTiers_List
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommitmentTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommitmentTier> GetCommitmentTiers(AzureLocation location, CancellationToken cancellationToken = default)
        {
            Page<CommitmentTier> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CommitmentTiersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCommitmentTiers");
                scope.Start();
                try
                {
                    var response = CommitmentTiersRestClient.List(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommitmentTier> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CommitmentTiersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCommitmentTiers");
                scope.Start();
                try
                {
                    var response = CommitmentTiersRestClient.ListNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}

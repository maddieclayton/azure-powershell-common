// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NetworkInterfaceIPConfigurationsOperations.
    /// </summary>
    public static partial class NetworkInterfaceIPConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Get all ip configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static IPage<NetworkInterfaceIPConfiguration> List(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.ListAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all ip configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterfaceIPConfiguration>> ListAsync(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified network interface ip configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='ipConfigurationName'>
            /// The name of the ip configuration name.
            /// </param>
            public static NetworkInterfaceIPConfiguration Get(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string ipConfigurationName)
            {
                return operations.GetAsync(resourceGroupName, networkInterfaceName, ipConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified network interface ip configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='ipConfigurationName'>
            /// The name of the ip configuration name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterfaceIPConfiguration> GetAsync(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string ipConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, ipConfigurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all ip configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterfaceIPConfiguration> ListNext(this INetworkInterfaceIPConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all ip configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterfaceIPConfiguration>> ListNextAsync(this INetworkInterfaceIPConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

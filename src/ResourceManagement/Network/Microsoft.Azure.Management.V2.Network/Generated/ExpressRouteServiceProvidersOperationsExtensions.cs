// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ExpressRouteServiceProvidersOperations.
    /// </summary>
    public static partial class ExpressRouteServiceProvidersOperationsExtensions
    {
            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ExpressRouteServiceProviderInner> List(this IExpressRouteServiceProvidersOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteServiceProvidersOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ExpressRouteServiceProviderInner>> ListAsync(this IExpressRouteServiceProvidersOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ExpressRouteServiceProviderInner> ListNext(this IExpressRouteServiceProvidersOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteServiceProvidersOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
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
            public static async Task<Microsoft.Rest.Azure.IPage<ExpressRouteServiceProviderInner>> ListNextAsync(this IExpressRouteServiceProvidersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public static partial class AlertSettingsOperationsExtensions
    {
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='alertSettingsName'>
        /// Required. Alert Settings name.
        /// </param>
        /// <param name='input'>
        /// Required. Configure Alerts Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        public static AlertSettingsResponse Configure(this IAlertSettingsOperations operations, string alertSettingsName, ConfigureAlertSettingsRequest input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertSettingsOperations)s).ConfigureAsync(alertSettingsName, input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='alertSettingsName'>
        /// Required. Alert Settings name.
        /// </param>
        /// <param name='input'>
        /// Required. Configure Alerts Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        public static Task<AlertSettingsResponse> ConfigureAsync(this IAlertSettingsOperations operations, string alertSettingsName, ConfigureAlertSettingsRequest input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ConfigureAsync(alertSettingsName, input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='alertSettingsName'>
        /// Required. Alert Settings name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        public static AlertSettingsResponse Get(this IAlertSettingsOperations operations, string alertSettingsName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertSettingsOperations)s).GetAsync(alertSettingsName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='alertSettingsName'>
        /// Required. Alert Settings name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        public static Task<AlertSettingsResponse> GetAsync(this IAlertSettingsOperations operations, string alertSettingsName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(alertSettingsName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for list alerts response.
        /// </returns>
        public static AlertSettingsListResponse List(this IAlertSettingsOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertSettingsOperations)s).ListAsync(customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IAlertSettingsOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for list alerts response.
        /// </returns>
        public static Task<AlertSettingsListResponse> ListAsync(this IAlertSettingsOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(customRequestHeaders, CancellationToken.None);
        }
    }
}

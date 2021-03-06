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
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.StoreFileSystem;

namespace Microsoft.Azure.Management.DataLake.StoreFileSystem
{
    /// <summary>
    /// Creates a Data Lake Store filesystem management client.
    /// </summary>
    public partial interface IDataLakeStoreFileSystemManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        string DataLakeServiceUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the additional UserAgent text to be added to the user
        /// agent header. This is used to further differentiate where requests
        /// are coming from internally.
        /// </summary>
        string UserAgentSuffix
        {
            get; set; 
        }
        
        /// <summary>
        /// Operations for managing the Data Lake Store filesystem
        /// </summary>
        IFileSystemOperations FileSystem
        {
            get; 
        }
    }
}

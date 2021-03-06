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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of recovery point operations for Site recovery extension.
    /// </summary>
    internal partial class RecoveryPointOperations : IServiceOperations<SiteRecoveryManagementClient>, IRecoveryPointOperations
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPointOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RecoveryPointOperations(SiteRecoveryManagementClient client)
        {
            this._client = client;
        }
        
        private SiteRecoveryManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.SiteRecovery.SiteRecoveryManagementClient.
        /// </summary>
        public SiteRecoveryManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get a specific recovery point for a replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='replicationProtectedItemName'>
        /// Required. Replication protected item's name.
        /// </param>
        /// <param name='recoveryPointName'>
        /// Required. Recovery point name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for recovery point object.
        /// </returns>
        public async Task<RecoveryPointResponse> GetAsync(string fabricName, string protectionContainerName, string replicationProtectedItemName, string recoveryPointName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (fabricName == null)
            {
                throw new ArgumentNullException("fabricName");
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException("protectionContainerName");
            }
            if (replicationProtectedItemName == null)
            {
                throw new ArgumentNullException("replicationProtectedItemName");
            }
            if (recoveryPointName == null)
            {
                throw new ArgumentNullException("recoveryPointName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("fabricName", fabricName);
                tracingParameters.Add("protectionContainerName", protectionContainerName);
                tracingParameters.Add("replicationProtectedItemName", replicationProtectedItemName);
                tracingParameters.Add("recoveryPointName", recoveryPointName);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceType);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/replicationFabrics/";
            url = url + Uri.EscapeDataString(fabricName);
            url = url + "/replicationProtectionContainers/";
            url = url + Uri.EscapeDataString(protectionContainerName);
            url = url + "/replicationProtectedItems/";
            url = url + Uri.EscapeDataString(replicationProtectedItemName);
            url = url + "/recoveryPoints/";
            url = url + Uri.EscapeDataString(recoveryPointName);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RecoveryPointResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new RecoveryPointResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            RecoveryPoint recoveryPointInstance = new RecoveryPoint();
                            result.RecoveryPoint = recoveryPointInstance;
                            
                            JToken propertiesValue = responseDoc["properties"];
                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                            {
                                RecoveryPointProperties propertiesInstance = new RecoveryPointProperties();
                                recoveryPointInstance.Properties = propertiesInstance;
                                
                                JToken recoveryPointTimeValue = propertiesValue["recoveryPointTime"];
                                if (recoveryPointTimeValue != null && recoveryPointTimeValue.Type != JTokenType.Null)
                                {
                                    DateTime recoveryPointTimeInstance = ((DateTime)recoveryPointTimeValue);
                                    propertiesInstance.RecoveryPointTime = recoveryPointTimeInstance;
                                }
                                
                                JToken recoveryPointTypeValue = propertiesValue["recoveryPointType"];
                                if (recoveryPointTypeValue != null && recoveryPointTypeValue.Type != JTokenType.Null)
                                {
                                    string recoveryPointTypeInstance = ((string)recoveryPointTypeValue);
                                    propertiesInstance.RecoveryPointType = recoveryPointTypeInstance;
                                }
                            }
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                recoveryPointInstance.Id = idInstance;
                            }
                            
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                recoveryPointInstance.Name = nameInstance;
                            }
                            
                            JToken typeValue = responseDoc["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                recoveryPointInstance.Type = typeInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                recoveryPointInstance.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    recoveryPointInstance.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                            
                            JToken clientRequestIdValue = responseDoc["ClientRequestId"];
                            if (clientRequestIdValue != null && clientRequestIdValue.Type != JTokenType.Null)
                            {
                                string clientRequestIdInstance = ((string)clientRequestIdValue);
                                result.ClientRequestId = clientRequestIdInstance;
                            }
                            
                            JToken correlationRequestIdValue = responseDoc["CorrelationRequestId"];
                            if (correlationRequestIdValue != null && correlationRequestIdValue.Type != JTokenType.Null)
                            {
                                string correlationRequestIdInstance = ((string)correlationRequestIdValue);
                                result.CorrelationRequestId = correlationRequestIdInstance;
                            }
                            
                            JToken dateValue = responseDoc["Date"];
                            if (dateValue != null && dateValue.Type != JTokenType.Null)
                            {
                                string dateInstance = ((string)dateValue);
                                result.Date = dateInstance;
                            }
                            
                            JToken contentTypeValue = responseDoc["ContentType"];
                            if (contentTypeValue != null && contentTypeValue.Type != JTokenType.Null)
                            {
                                string contentTypeInstance = ((string)contentTypeValue);
                                result.ContentType = contentTypeInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Content != null && httpResponse.Content.Headers.Contains("Content-Type"))
                    {
                        result.ContentType = httpResponse.Content.Headers.GetValues("Content-Type").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Date"))
                    {
                        result.Date = httpResponse.Headers.GetValues("Date").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        result.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-correlation-request-id"))
                    {
                        result.CorrelationRequestId = httpResponse.Headers.GetValues("x-ms-correlation-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Get all recovery points for a replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Required. Protection container unique name.
        /// </param>
        /// <param name='replicationProtectedItemName'>
        /// Required. Replication protected item's name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for a list of recovery points.
        /// </returns>
        public async Task<RecoveryPointListResponse> ListAsync(string fabricName, string protectionContainerName, string replicationProtectedItemName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (fabricName == null)
            {
                throw new ArgumentNullException("fabricName");
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException("protectionContainerName");
            }
            if (replicationProtectedItemName == null)
            {
                throw new ArgumentNullException("replicationProtectedItemName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("fabricName", fabricName);
                tracingParameters.Add("protectionContainerName", protectionContainerName);
                tracingParameters.Add("replicationProtectedItemName", replicationProtectedItemName);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceType);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/replicationFabrics/";
            url = url + Uri.EscapeDataString(fabricName);
            url = url + "/replicationProtectionContainers/";
            url = url + Uri.EscapeDataString(protectionContainerName);
            url = url + "/replicationProtectedItems/";
            url = url + Uri.EscapeDataString(replicationProtectedItemName);
            url = url + "/recoveryPoints";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RecoveryPointListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new RecoveryPointListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    RecoveryPoint recoveryPointInstance = new RecoveryPoint();
                                    result.RecoveryPoints.Add(recoveryPointInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        RecoveryPointProperties propertiesInstance = new RecoveryPointProperties();
                                        recoveryPointInstance.Properties = propertiesInstance;
                                        
                                        JToken recoveryPointTimeValue = propertiesValue["recoveryPointTime"];
                                        if (recoveryPointTimeValue != null && recoveryPointTimeValue.Type != JTokenType.Null)
                                        {
                                            DateTime recoveryPointTimeInstance = ((DateTime)recoveryPointTimeValue);
                                            propertiesInstance.RecoveryPointTime = recoveryPointTimeInstance;
                                        }
                                        
                                        JToken recoveryPointTypeValue = propertiesValue["recoveryPointType"];
                                        if (recoveryPointTypeValue != null && recoveryPointTypeValue.Type != JTokenType.Null)
                                        {
                                            string recoveryPointTypeInstance = ((string)recoveryPointTypeValue);
                                            propertiesInstance.RecoveryPointType = recoveryPointTypeInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        recoveryPointInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        recoveryPointInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        recoveryPointInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        recoveryPointInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            recoveryPointInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                }
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                result.NextLink = nextLinkInstance;
                            }
                            
                            JToken clientRequestIdValue = responseDoc["ClientRequestId"];
                            if (clientRequestIdValue != null && clientRequestIdValue.Type != JTokenType.Null)
                            {
                                string clientRequestIdInstance = ((string)clientRequestIdValue);
                                result.ClientRequestId = clientRequestIdInstance;
                            }
                            
                            JToken correlationRequestIdValue = responseDoc["CorrelationRequestId"];
                            if (correlationRequestIdValue != null && correlationRequestIdValue.Type != JTokenType.Null)
                            {
                                string correlationRequestIdInstance = ((string)correlationRequestIdValue);
                                result.CorrelationRequestId = correlationRequestIdInstance;
                            }
                            
                            JToken dateValue = responseDoc["Date"];
                            if (dateValue != null && dateValue.Type != JTokenType.Null)
                            {
                                string dateInstance = ((string)dateValue);
                                result.Date = dateInstance;
                            }
                            
                            JToken contentTypeValue = responseDoc["ContentType"];
                            if (contentTypeValue != null && contentTypeValue.Type != JTokenType.Null)
                            {
                                string contentTypeInstance = ((string)contentTypeValue);
                                result.ContentType = contentTypeInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Content != null && httpResponse.Content.Headers.Contains("Content-Type"))
                    {
                        result.ContentType = httpResponse.Content.Headers.GetValues("Content-Type").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Date"))
                    {
                        result.Date = httpResponse.Headers.GetValues("Date").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        result.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-correlation-request-id"))
                    {
                        result.CorrelationRequestId = httpResponse.Headers.GetValues("x-ms-correlation-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}

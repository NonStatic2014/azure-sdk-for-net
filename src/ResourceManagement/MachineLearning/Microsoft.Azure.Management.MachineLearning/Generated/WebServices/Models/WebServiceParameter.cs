// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Web Service Parameter object for node and global parameter
    /// </summary>
    public partial class WebServiceParameter
    {
        /// <summary>
        /// Initializes a new instance of the WebServiceParameter class.
        /// </summary>
        public WebServiceParameter() { }

        /// <summary>
        /// Initializes a new instance of the WebServiceParameter class.
        /// </summary>
        /// <param name="value">The parameter value</param>
        /// <param name="certificateThumbprint">If the parameter value in
        /// 'value' field is encrypted, the thumbprint of the certificate
        /// should be put here.</param>
        public WebServiceParameter(object value = default(object), string certificateThumbprint = default(string))
        {
            Value = value;
            CertificateThumbprint = certificateThumbprint;
        }

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets if the parameter value in 'value' field is encrypted,
        /// the thumbprint of the certificate should be put here.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateThumbprint")]
        public string CertificateThumbprint { get; set; }

    }
}
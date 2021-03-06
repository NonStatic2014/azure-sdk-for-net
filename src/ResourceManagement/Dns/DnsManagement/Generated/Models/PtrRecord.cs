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

namespace Microsoft.Azure.Management.Dns.Models
{
    /// <summary>
    /// A PTR record.
    /// </summary>
    public partial class PtrRecord
    {
        private string _ptrdname;
        
        /// <summary>
        /// Required. Gets or sets the PTR target domain name for this record
        /// without a terminating dot.
        /// </summary>
        public string Ptrdname
        {
            get { return this._ptrdname; }
            set { this._ptrdname = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PtrRecord class.
        /// </summary>
        public PtrRecord()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PtrRecord class with required
        /// arguments.
        /// </summary>
        public PtrRecord(string ptrdname)
            : this()
        {
            if (ptrdname == null)
            {
                throw new ArgumentNullException("ptrdname");
            }
            this.Ptrdname = ptrdname;
        }
    }
}

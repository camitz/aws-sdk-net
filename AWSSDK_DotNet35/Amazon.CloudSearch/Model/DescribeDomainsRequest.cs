/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDomains operation.
    /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
    /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Information about
    /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
    /// </summary>
    public partial class DescribeDomainsRequest : AmazonCloudSearchRequest
    {
        private List<string> domainNames = new List<string>();


        /// <summary>
        /// The names of the domains you want to include in the response.
        ///  
        /// </summary>
        public List<string> DomainNames
        {
            get { return this.domainNames; }
            set { this.domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this.domainNames.Count > 0;
        }

    }
}
    
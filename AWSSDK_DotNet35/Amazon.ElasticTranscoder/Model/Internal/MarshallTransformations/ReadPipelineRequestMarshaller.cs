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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Read Pipeline Request Marshaller
    /// </summary>       
    internal class ReadPipelineRequestMarshaller : IMarshaller<IRequest, ReadPipelineRequest> 
    {
        

        public IRequest Marshall(ReadPipelineRequest readPipelineRequest) 
        {

            IRequest request = new DefaultRequest(readPipelineRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.ReadPipeline";
            request.Headers["X-Amz-Target"] = target;
            request.HttpMethod = "GET";
            string uriResourcePath = "2012-09-25/pipelines/{Id}"; 
            if(readPipelineRequest.IsSetId())
                uriResourcePath = uriResourcePath.Replace("{Id}", StringUtils.FromString(readPipelineRequest.Id) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{Id}", "" ); 
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
        

            return request;
        }
    }
}

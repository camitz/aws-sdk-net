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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ReservedInstancesModification Unmarshaller
     /// </summary>
    internal class ReservedInstancesModificationUnmarshaller : IUnmarshaller<ReservedInstancesModification, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstancesModification, JsonUnmarshallerContext> 
    {
        public ReservedInstancesModification Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedInstancesModification reservedInstancesModification = new ReservedInstancesModification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("reservedInstancesModificationId", targetDepth))
                    {
                        reservedInstancesModification.ReservedInstancesModificationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesSet/item", targetDepth))
                    {
                        reservedInstancesModification.ReservedInstancesIds.Add(ReservedInstancesIdUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("modificationResultSet/item", targetDepth))
                    {
                        reservedInstancesModification.ModificationResults.Add(ReservedInstancesModificationResultUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("createDate", targetDepth))
                    {
                        reservedInstancesModification.CreateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("updateDate", targetDepth))
                    {
                        reservedInstancesModification.UpdateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("effectiveDate", targetDepth))
                    {
                        reservedInstancesModification.EffectiveDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        reservedInstancesModification.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        reservedInstancesModification.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        reservedInstancesModification.ClientToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedInstancesModification;
                }
            }
                        


            return reservedInstancesModification;
        }

        public ReservedInstancesModification Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedInstancesModificationUnmarshaller instance;

        public static ReservedInstancesModificationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedInstancesModificationUnmarshaller();

            return instance;
        }
    }
}
    

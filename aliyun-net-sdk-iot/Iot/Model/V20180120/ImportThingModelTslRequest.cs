/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class ImportThingModelTslRequest : RpcAcsRequest<ImportThingModelTslResponse>
    {
        public ImportThingModelTslRequest()
            : base("Iot", "2018-01-20", "ImportThingModelTsl")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private string iotInstanceId;

		private string functionBlockName;

		private string productKey;

		private string tslUrl;

		private string tslStr;

		private string functionBlockId;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string FunctionBlockName
		{
			get
			{
				return functionBlockName;
			}
			set	
			{
				functionBlockName = value;
				DictionaryUtil.Add(QueryParameters, "FunctionBlockName", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string TslUrl
		{
			get
			{
				return tslUrl;
			}
			set	
			{
				tslUrl = value;
				DictionaryUtil.Add(QueryParameters, "TslUrl", value);
			}
		}

		public string TslStr
		{
			get
			{
				return tslStr;
			}
			set	
			{
				tslStr = value;
				DictionaryUtil.Add(QueryParameters, "TslStr", value);
			}
		}

		public string FunctionBlockId
		{
			get
			{
				return functionBlockId;
			}
			set	
			{
				functionBlockId = value;
				DictionaryUtil.Add(QueryParameters, "FunctionBlockId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImportThingModelTslResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportThingModelTslResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

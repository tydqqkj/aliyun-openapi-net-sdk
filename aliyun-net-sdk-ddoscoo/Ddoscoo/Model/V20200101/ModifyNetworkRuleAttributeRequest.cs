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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class ModifyNetworkRuleAttributeRequest : RpcAcsRequest<ModifyNetworkRuleAttributeResponse>
    {
        public ModifyNetworkRuleAttributeRequest()
            : base("ddoscoo", "2020-01-01", "ModifyNetworkRuleAttribute")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string instanceId;

		private int? frontendPort;

		private string forwardProtocol;

		private string config;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public int? FrontendPort
		{
			get
			{
				return frontendPort;
			}
			set	
			{
				frontendPort = value;
				DictionaryUtil.Add(QueryParameters, "FrontendPort", value.ToString());
			}
		}

		public string ForwardProtocol
		{
			get
			{
				return forwardProtocol;
			}
			set	
			{
				forwardProtocol = value;
				DictionaryUtil.Add(QueryParameters, "ForwardProtocol", value);
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyNetworkRuleAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyNetworkRuleAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
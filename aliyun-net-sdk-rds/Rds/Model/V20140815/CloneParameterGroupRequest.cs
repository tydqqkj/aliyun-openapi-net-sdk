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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CloneParameterGroupRequest : RpcAcsRequest<CloneParameterGroupResponse>
    {
        public CloneParameterGroupRequest()
            : base("Rds", "2014-08-15", "CloneParameterGroup", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string parameterGroupId;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string targetRegionId;

		private string parameterGroupName;

		private string parameterGroupDesc;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ParameterGroupId")]
		public string ParameterGroupId
		{
			get
			{
				return parameterGroupId;
			}
			set	
			{
				parameterGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ParameterGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TargetRegionId")]
		public string TargetRegionId
		{
			get
			{
				return targetRegionId;
			}
			set	
			{
				targetRegionId = value;
				DictionaryUtil.Add(QueryParameters, "TargetRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "ParameterGroupName")]
		public string ParameterGroupName
		{
			get
			{
				return parameterGroupName;
			}
			set	
			{
				parameterGroupName = value;
				DictionaryUtil.Add(QueryParameters, "ParameterGroupName", value);
			}
		}

		[JsonProperty(PropertyName = "ParameterGroupDesc")]
		public string ParameterGroupDesc
		{
			get
			{
				return parameterGroupDesc;
			}
			set	
			{
				parameterGroupDesc = value;
				DictionaryUtil.Add(QueryParameters, "ParameterGroupDesc", value);
			}
		}

        public override CloneParameterGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CloneParameterGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

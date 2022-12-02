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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateLiveSnapshotNotifyConfigRequest : RpcAcsRequest<UpdateLiveSnapshotNotifyConfigResponse>
    {
        public UpdateLiveSnapshotNotifyConfigRequest()
            : base("live", "2016-11-01", "UpdateLiveSnapshotNotifyConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string notifyReqAuth;

		private string notifyUrl;

		private string domainName;

		private long? ownerId;

		private string notifyAuthKey;

		[JsonProperty(PropertyName = "NotifyReqAuth")]
		public string NotifyReqAuth
		{
			get
			{
				return notifyReqAuth;
			}
			set	
			{
				notifyReqAuth = value;
				DictionaryUtil.Add(QueryParameters, "NotifyReqAuth", value);
			}
		}

		[JsonProperty(PropertyName = "NotifyUrl")]
		public string NotifyUrl
		{
			get
			{
				return notifyUrl;
			}
			set	
			{
				notifyUrl = value;
				DictionaryUtil.Add(QueryParameters, "NotifyUrl", value);
			}
		}

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		[JsonProperty(PropertyName = "NotifyAuthKey")]
		public string NotifyAuthKey
		{
			get
			{
				return notifyAuthKey;
			}
			set	
			{
				notifyAuthKey = value;
				DictionaryUtil.Add(QueryParameters, "NotifyAuthKey", value);
			}
		}

        public override UpdateLiveSnapshotNotifyConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveSnapshotNotifyConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

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
using Aliyun.Acs.scdn;
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class PreloadScdnObjectCachesRequest : RpcAcsRequest<PreloadScdnObjectCachesResponse>
    {
        public PreloadScdnObjectCachesRequest()
            : base("scdn", "2017-11-15", "PreloadScdnObjectCaches")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string objectPath;

		private string securityToken;

		private bool? l2Preload;

		private string area;

		private long? ownerId;

		public string ObjectPath
		{
			get
			{
				return objectPath;
			}
			set	
			{
				objectPath = value;
				DictionaryUtil.Add(QueryParameters, "ObjectPath", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public bool? L2Preload
		{
			get
			{
				return l2Preload;
			}
			set	
			{
				l2Preload = value;
				DictionaryUtil.Add(QueryParameters, "L2Preload", value.ToString());
			}
		}

		public string Area
		{
			get
			{
				return area;
			}
			set	
			{
				area = value;
				DictionaryUtil.Add(QueryParameters, "Area", value);
			}
		}

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

        public override PreloadScdnObjectCachesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PreloadScdnObjectCachesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

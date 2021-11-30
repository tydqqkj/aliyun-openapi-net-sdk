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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class QueryUnionPromotionRequest : RpcAcsRequest<QueryUnionPromotionResponse>
    {
        public QueryUnionPromotionRequest()
            : base("UniMkt", "2018-12-12", "QueryUnionPromotion", "1.0.0", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string unionBizType;

		private string proxyChannelId;

		private string userNick;

		private string sign;

		private long? alipayOpenId;

		private long? userId;

		private string channelId;

		public string UnionBizType
		{
			get
			{
				return unionBizType;
			}
			set	
			{
				unionBizType = value;
				DictionaryUtil.Add(QueryParameters, "UnionBizType", value);
			}
		}

		public string ProxyChannelId
		{
			get
			{
				return proxyChannelId;
			}
			set	
			{
				proxyChannelId = value;
				DictionaryUtil.Add(QueryParameters, "ProxyChannelId", value);
			}
		}

		public string UserNick
		{
			get
			{
				return userNick;
			}
			set	
			{
				userNick = value;
				DictionaryUtil.Add(QueryParameters, "UserNick", value);
			}
		}

		public string Sign
		{
			get
			{
				return sign;
			}
			set	
			{
				sign = value;
				DictionaryUtil.Add(QueryParameters, "Sign", value);
			}
		}

		public long? AlipayOpenId
		{
			get
			{
				return alipayOpenId;
			}
			set	
			{
				alipayOpenId = value;
				DictionaryUtil.Add(QueryParameters, "AlipayOpenId", value.ToString());
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value.ToString());
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryUnionPromotionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryUnionPromotionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

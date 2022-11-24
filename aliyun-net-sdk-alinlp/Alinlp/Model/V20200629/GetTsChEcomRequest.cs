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
using Aliyun.Acs.alinlp;
using Aliyun.Acs.alinlp.Transform;
using Aliyun.Acs.alinlp.Transform.V20200629;

namespace Aliyun.Acs.alinlp.Model.V20200629
{
    public class GetTsChEcomRequest : RpcAcsRequest<GetTsChEcomResponse>
    {
        public GetTsChEcomRequest()
            : base("alinlp", "2020-06-29", "GetTsChEcom")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alinlp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alinlp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private string serviceCode;

		private string originT;

		private string originQ;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string ServiceCode
		{
			get
			{
				return serviceCode;
			}
			set	
			{
				serviceCode = value;
				DictionaryUtil.Add(BodyParameters, "ServiceCode", value);
			}
		}

		public string OriginT
		{
			get
			{
				return originT;
			}
			set	
			{
				originT = value;
				DictionaryUtil.Add(BodyParameters, "OriginT", value);
			}
		}

		public string OriginQ
		{
			get
			{
				return originQ;
			}
			set	
			{
				originQ = value;
				DictionaryUtil.Add(BodyParameters, "OriginQ", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTsChEcomResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTsChEcomResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

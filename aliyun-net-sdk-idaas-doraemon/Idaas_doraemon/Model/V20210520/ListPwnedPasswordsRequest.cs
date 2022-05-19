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
using Aliyun.Acs.idaas_doraemon;
using Aliyun.Acs.idaas_doraemon.Transform;
using Aliyun.Acs.idaas_doraemon.Transform.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
    public class ListPwnedPasswordsRequest : RpcAcsRequest<ListPwnedPasswordsResponse>
    {
        public ListPwnedPasswordsRequest()
            : base("idaas-doraemon", "2021-05-20", "ListPwnedPasswords")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string prefixHexPasswordSha1Hash;

		public string PrefixHexPasswordSha1Hash
		{
			get
			{
				return prefixHexPasswordSha1Hash;
			}
			set	
			{
				prefixHexPasswordSha1Hash = value;
				DictionaryUtil.Add(QueryParameters, "PrefixHexPasswordSha1Hash", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPwnedPasswordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPwnedPasswordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

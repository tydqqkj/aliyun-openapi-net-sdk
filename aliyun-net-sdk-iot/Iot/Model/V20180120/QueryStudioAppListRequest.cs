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
    public class QueryStudioAppListRequest : RpcAcsRequest<QueryStudioAppListResponse>
    {
        public QueryStudioAppListRequest()
            : base("Iot", "2018-01-20", "QueryStudioAppList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private int? pageSize;

		private string projectId;

		private List<string> typess = new List<string>(){ };

		private string fuzzyName;

		private int? pageNo;

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "IotInstanceId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
			}
		}

		public List<string> Typess
		{
			get
			{
				return typess;
			}

			set
			{
				typess = value;
				for (int i = 0; i < typess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Types." + (i + 1) , typess[i]);
				}
			}
		}

		public string FuzzyName
		{
			get
			{
				return fuzzyName;
			}
			set	
			{
				fuzzyName = value;
				DictionaryUtil.Add(BodyParameters, "FuzzyName", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(BodyParameters, "PageNo", value.ToString());
			}
		}

        public override QueryStudioAppListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryStudioAppListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

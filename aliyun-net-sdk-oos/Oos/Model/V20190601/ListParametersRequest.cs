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
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class ListParametersRequest : RpcAcsRequest<ListParametersResponse>
    {
        public ListParametersRequest()
            : base("oos", "2019-06-01", "ListParameters", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private bool? recursive;

		private string path;

		private string resourceGroupId;

		private string nextToken;

		private string sortOrder;

		private string tags;

		private string name;

		private int? maxResults;

		private string sortField;

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "Recursive")]
		public bool? Recursive
		{
			get
			{
				return recursive;
			}
			set	
			{
				recursive = value;
				DictionaryUtil.Add(QueryParameters, "Recursive", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Path")]
		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "SortOrder")]
		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SortField")]
		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(QueryParameters, "SortField", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListParametersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListParametersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

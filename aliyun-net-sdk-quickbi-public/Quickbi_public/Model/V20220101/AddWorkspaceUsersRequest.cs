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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class AddWorkspaceUsersRequest : RpcAcsRequest<AddWorkspaceUsersResponse>
    {
        public AddWorkspaceUsersRequest()
            : base("quickbi-public", "2022-01-01", "AddWorkspaceUsers", "quickbi", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string userIds;

		private long? roleId;

		private string workspaceId;

		public string UserIds
		{
			get
			{
				return userIds;
			}
			set	
			{
				userIds = value;
				DictionaryUtil.Add(QueryParameters, "UserIds", value);
			}
		}

		public long? RoleId
		{
			get
			{
				return roleId;
			}
			set	
			{
				roleId = value;
				DictionaryUtil.Add(QueryParameters, "RoleId", value.ToString());
			}
		}

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddWorkspaceUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddWorkspaceUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

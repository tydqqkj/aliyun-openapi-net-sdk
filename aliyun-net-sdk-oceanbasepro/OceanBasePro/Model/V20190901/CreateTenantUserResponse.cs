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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class CreateTenantUserResponse : AcsResponse
	{

		private string requestId;

		private List<CreateTenantUser_Data> tenantUser;

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "TenantUser")]
		public List<CreateTenantUser_Data> TenantUser
		{
			get
			{
				return tenantUser;
			}
			set	
			{
				tenantUser = value;
			}
		}

		public class CreateTenantUser_Data
		{

			private string userType;

			private string userStatus;

			private string userName;

			private List<CreateTenantUser_RolesItem> roles;

			[JsonProperty(PropertyName = "UserType")]
			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			[JsonProperty(PropertyName = "UserStatus")]
			public string UserStatus
			{
				get
				{
					return userStatus;
				}
				set	
				{
					userStatus = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			[JsonProperty(PropertyName = "Roles")]
			public List<CreateTenantUser_RolesItem> Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public class CreateTenantUser_RolesItem
			{

				private string database;

				private string role;

				[JsonProperty(PropertyName = "Database")]
				public string Database
				{
					get
					{
						return database;
					}
					set	
					{
						database = value;
					}
				}

				[JsonProperty(PropertyName = "Role")]
				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}
			}
		}
	}
}

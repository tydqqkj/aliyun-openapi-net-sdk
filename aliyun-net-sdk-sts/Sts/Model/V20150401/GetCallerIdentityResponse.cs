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

namespace Aliyun.Acs.Sts.Model.V20150401
{
	public class GetCallerIdentityResponse : AcsResponse
	{

		private string identityType;

		private string accountId;

		private string requestId;

		private string principalId;

		private string userId;

		private string arn;

		private string roleId;

		public string IdentityType
		{
			get
			{
				return identityType;
			}
			set	
			{
				identityType = value;
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
			}
		}

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

		public string PrincipalId
		{
			get
			{
				return principalId;
			}
			set	
			{
				principalId = value;
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public string Arn
		{
			get
			{
				return arn;
			}
			set	
			{
				arn = value;
			}
		}

		public string RoleId
		{
			get
			{
				return roleId;
			}
			set	
			{
				roleId = value;
			}
		}
	}
}

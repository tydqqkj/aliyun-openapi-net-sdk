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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class ScrollDomainListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private string scrollId;

		private int? totalItemNum;

		private List<ScrollDomainList_Domain> data;

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public string ScrollId
		{
			get
			{
				return scrollId;
			}
			set	
			{
				scrollId = value;
			}
		}

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public List<ScrollDomainList_Domain> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ScrollDomainList_Domain
		{

			private string domainAuditStatus;

			private string domainGroupId;

			private string remark;

			private string domainGroupName;

			private string zhRegistrantOrganization;

			private string registrantOrganization;

			private string registrationDate;

			private string instanceId;

			private string domainName;

			private string expirationDateStatus;

			private string expirationDate;

			private string email;

			private string registrantType;

			private long? expirationDateLong;

			private int? expirationCurrDateDiff;

			private bool? premium;

			private long? registrationDateLong;

			private string productId;

			private string domainStatus;

			private string domainType;

			private List<string> dnsList;

			public string DomainAuditStatus
			{
				get
				{
					return domainAuditStatus;
				}
				set	
				{
					domainAuditStatus = value;
				}
			}

			public string DomainGroupId
			{
				get
				{
					return domainGroupId;
				}
				set	
				{
					domainGroupId = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string DomainGroupName
			{
				get
				{
					return domainGroupName;
				}
				set	
				{
					domainGroupName = value;
				}
			}

			public string ZhRegistrantOrganization
			{
				get
				{
					return zhRegistrantOrganization;
				}
				set	
				{
					zhRegistrantOrganization = value;
				}
			}

			public string RegistrantOrganization
			{
				get
				{
					return registrantOrganization;
				}
				set	
				{
					registrantOrganization = value;
				}
			}

			public string RegistrationDate
			{
				get
				{
					return registrationDate;
				}
				set	
				{
					registrationDate = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string ExpirationDateStatus
			{
				get
				{
					return expirationDateStatus;
				}
				set	
				{
					expirationDateStatus = value;
				}
			}

			public string ExpirationDate
			{
				get
				{
					return expirationDate;
				}
				set	
				{
					expirationDate = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string RegistrantType
			{
				get
				{
					return registrantType;
				}
				set	
				{
					registrantType = value;
				}
			}

			public long? ExpirationDateLong
			{
				get
				{
					return expirationDateLong;
				}
				set	
				{
					expirationDateLong = value;
				}
			}

			public int? ExpirationCurrDateDiff
			{
				get
				{
					return expirationCurrDateDiff;
				}
				set	
				{
					expirationCurrDateDiff = value;
				}
			}

			public bool? Premium
			{
				get
				{
					return premium;
				}
				set	
				{
					premium = value;
				}
			}

			public long? RegistrationDateLong
			{
				get
				{
					return registrationDateLong;
				}
				set	
				{
					registrationDateLong = value;
				}
			}

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}

			public string DomainType
			{
				get
				{
					return domainType;
				}
				set	
				{
					domainType = value;
				}
			}

			public List<string> DnsList
			{
				get
				{
					return dnsList;
				}
				set	
				{
					dnsList = value;
				}
			}
		}
	}
}

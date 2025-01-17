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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class UpdateDhcpOptionsSetAttributeRequest : RpcAcsRequest<UpdateDhcpOptionsSetAttributeResponse>
    {
        public UpdateDhcpOptionsSetAttributeRequest()
            : base("Vpc", "2016-04-28", "UpdateDhcpOptionsSetAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string bootFileName;

		private long? resourceOwnerId;

		private string clientToken;

		private string tFTPServerName;

		private string leaseTime;

		private string domainNameServers;

		private string dhcpOptionsSetDescription;

		private bool? dryRun;

		private string dhcpOptionsSetId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string domainName;

		private long? ownerId;

		private string dhcpOptionsSetName;

		private string ipv6LeaseTime;

		public string BootFileName
		{
			get
			{
				return bootFileName;
			}
			set	
			{
				bootFileName = value;
				DictionaryUtil.Add(QueryParameters, "BootFileName", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string TFTPServerName
		{
			get
			{
				return tFTPServerName;
			}
			set	
			{
				tFTPServerName = value;
				DictionaryUtil.Add(QueryParameters, "TFTPServerName", value);
			}
		}

		public string LeaseTime
		{
			get
			{
				return leaseTime;
			}
			set	
			{
				leaseTime = value;
				DictionaryUtil.Add(QueryParameters, "LeaseTime", value);
			}
		}

		public string DomainNameServers
		{
			get
			{
				return domainNameServers;
			}
			set	
			{
				domainNameServers = value;
				DictionaryUtil.Add(QueryParameters, "DomainNameServers", value);
			}
		}

		public string DhcpOptionsSetDescription
		{
			get
			{
				return dhcpOptionsSetDescription;
			}
			set	
			{
				dhcpOptionsSetDescription = value;
				DictionaryUtil.Add(QueryParameters, "DhcpOptionsSetDescription", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string DhcpOptionsSetId
		{
			get
			{
				return dhcpOptionsSetId;
			}
			set	
			{
				dhcpOptionsSetId = value;
				DictionaryUtil.Add(QueryParameters, "DhcpOptionsSetId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		public string DhcpOptionsSetName
		{
			get
			{
				return dhcpOptionsSetName;
			}
			set	
			{
				dhcpOptionsSetName = value;
				DictionaryUtil.Add(QueryParameters, "DhcpOptionsSetName", value);
			}
		}

		public string Ipv6LeaseTime
		{
			get
			{
				return ipv6LeaseTime;
			}
			set	
			{
				ipv6LeaseTime = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6LeaseTime", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDhcpOptionsSetAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDhcpOptionsSetAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

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
    public class CreateTrafficMirrorSessionRequest : RpcAcsRequest<CreateTrafficMirrorSessionResponse>
    {
        public CreateTrafficMirrorSessionRequest()
            : base("Vpc", "2016-04-28", "CreateTrafficMirrorSession", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string trafficMirrorTargetType;

		private long? resourceOwnerId;

		private string clientToken;

		private bool? enabled;

		private string trafficMirrorSessionName;

		private string trafficMirrorSessionDescription;

		private List<string> trafficMirrorSourceIdss = new List<string>(){ };

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? priority;

		private long? ownerId;

		private string trafficMirrorTargetId;

		private string trafficMirrorFilterId;

		private int? packetLength;

		private int? virtualNetworkId;

		public string TrafficMirrorTargetType
		{
			get
			{
				return trafficMirrorTargetType;
			}
			set	
			{
				trafficMirrorTargetType = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorTargetType", value);
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

		public bool? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
				DictionaryUtil.Add(QueryParameters, "Enabled", value.ToString());
			}
		}

		public string TrafficMirrorSessionName
		{
			get
			{
				return trafficMirrorSessionName;
			}
			set	
			{
				trafficMirrorSessionName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorSessionName", value);
			}
		}

		public string TrafficMirrorSessionDescription
		{
			get
			{
				return trafficMirrorSessionDescription;
			}
			set	
			{
				trafficMirrorSessionDescription = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorSessionDescription", value);
			}
		}

		public List<string> TrafficMirrorSourceIdss
		{
			get
			{
				return trafficMirrorSourceIdss;
			}

			set
			{
				trafficMirrorSourceIdss = value;
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

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
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

		public string TrafficMirrorTargetId
		{
			get
			{
				return trafficMirrorTargetId;
			}
			set	
			{
				trafficMirrorTargetId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorTargetId", value);
			}
		}

		public string TrafficMirrorFilterId
		{
			get
			{
				return trafficMirrorFilterId;
			}
			set	
			{
				trafficMirrorFilterId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorFilterId", value);
			}
		}

		public int? PacketLength
		{
			get
			{
				return packetLength;
			}
			set	
			{
				packetLength = value;
				DictionaryUtil.Add(QueryParameters, "PacketLength", value.ToString());
			}
		}

		public int? VirtualNetworkId
		{
			get
			{
				return virtualNetworkId;
			}
			set	
			{
				virtualNetworkId = value;
				DictionaryUtil.Add(QueryParameters, "VirtualNetworkId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTrafficMirrorSessionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTrafficMirrorSessionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

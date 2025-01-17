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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeNetworkAclsResponseUnmarshaller
    {
        public static DescribeNetworkAclsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkAclsResponse describeNetworkAclsResponse = new DescribeNetworkAclsResponse();

			describeNetworkAclsResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkAclsResponse.PageSize = _ctx.StringValue("DescribeNetworkAcls.PageSize");
			describeNetworkAclsResponse.RequestId = _ctx.StringValue("DescribeNetworkAcls.RequestId");
			describeNetworkAclsResponse.PageNumber = _ctx.StringValue("DescribeNetworkAcls.PageNumber");
			describeNetworkAclsResponse.TotalCount = _ctx.StringValue("DescribeNetworkAcls.TotalCount");

			List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl> describeNetworkAclsResponse_networkAcls = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkAcls.NetworkAcls.Length"); i++) {
				DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl networkAcl = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl();
				networkAcl.Status = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Status");
				networkAcl.VpcId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].VpcId");
				networkAcl.CreationTime = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].CreationTime");
				networkAcl.Description = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Description");
				networkAcl.NetworkAclName = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].NetworkAclName");
				networkAcl.NetworkAclId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].NetworkAclId");
				networkAcl.OwnerId = _ctx.LongValue("DescribeNetworkAcls.NetworkAcls["+ i +"].OwnerId");
				networkAcl.RegionId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].RegionId");

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry> networkAcl_ingressAclEntries = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry ingressAclEntry = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry();
					ingressAclEntry.NetworkAclEntryId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].NetworkAclEntryId");
					ingressAclEntry.EntryType = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].EntryType");
					ingressAclEntry.NetworkAclEntryName = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].NetworkAclEntryName");
					ingressAclEntry.Policy = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Policy");
					ingressAclEntry.Description = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Description");
					ingressAclEntry.SourceCidrIp = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].SourceCidrIp");
					ingressAclEntry.Protocol = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Protocol");
					ingressAclEntry.Port = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Port");

					networkAcl_ingressAclEntries.Add(ingressAclEntry);
				}
				networkAcl.IngressAclEntries = networkAcl_ingressAclEntries;

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry> networkAcl_egressAclEntries = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry egressAclEntry = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry();
					egressAclEntry.NetworkAclEntryId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].NetworkAclEntryId");
					egressAclEntry.EntryType = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].EntryType");
					egressAclEntry.NetworkAclEntryName = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].NetworkAclEntryName");
					egressAclEntry.Policy = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Policy");
					egressAclEntry.Description = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Description");
					egressAclEntry.Protocol = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Protocol");
					egressAclEntry.DestinationCidrIp = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].DestinationCidrIp");
					egressAclEntry.Port = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Port");

					networkAcl_egressAclEntries.Add(egressAclEntry);
				}
				networkAcl.EgressAclEntries = networkAcl_egressAclEntries;

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource> networkAcl_resources = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource resource = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource();
					resource.Status = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].Status");
					resource.ResourceType = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].ResourceType");
					resource.ResourceId = _ctx.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].ResourceId");

					networkAcl_resources.Add(resource);
				}
				networkAcl.Resources = networkAcl_resources;

				describeNetworkAclsResponse_networkAcls.Add(networkAcl);
			}
			describeNetworkAclsResponse.NetworkAcls = describeNetworkAclsResponse_networkAcls;
        
			return describeNetworkAclsResponse;
        }
    }
}

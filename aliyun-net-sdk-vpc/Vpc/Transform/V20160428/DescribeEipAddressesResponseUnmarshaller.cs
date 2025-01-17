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
    public class DescribeEipAddressesResponseUnmarshaller
    {
        public static DescribeEipAddressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEipAddressesResponse describeEipAddressesResponse = new DescribeEipAddressesResponse();

			describeEipAddressesResponse.HttpResponse = _ctx.HttpResponse;
			describeEipAddressesResponse.PageSize = _ctx.IntegerValue("DescribeEipAddresses.PageSize");
			describeEipAddressesResponse.RequestId = _ctx.StringValue("DescribeEipAddresses.RequestId");
			describeEipAddressesResponse.PageNumber = _ctx.IntegerValue("DescribeEipAddresses.PageNumber");
			describeEipAddressesResponse.TotalCount = _ctx.IntegerValue("DescribeEipAddresses.TotalCount");

			List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress> describeEipAddressesResponse_eipAddresses = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress>();
			for (int i = 0; i < _ctx.Length("DescribeEipAddresses.EipAddresses.Length"); i++) {
				DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress eipAddress = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress();
				eipAddress.ReservationActiveTime = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationActiveTime");
				eipAddress.Status = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Status");
				eipAddress.ReservationOrderType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationOrderType");
				eipAddress.AllocationTime = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationTime");
				eipAddress.Netmode = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Netmode");
				eipAddress.ChargeType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ChargeType");
				eipAddress.Descritpion = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Descritpion");
				eipAddress.Description = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Description");
				eipAddress.Mode = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Mode");
				eipAddress.SegmentInstanceId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].SegmentInstanceId");
				eipAddress.ReservationInternetChargeType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationInternetChargeType");
				eipAddress.BandwidthPackageId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageId");
				eipAddress.IpAddress = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].IpAddress");
				eipAddress.Bandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Bandwidth");
				eipAddress.ReservationBandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationBandwidth");
				eipAddress.EipBandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].EipBandwidth");
				eipAddress.Name = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Name");
				eipAddress.PrivateIpAddress = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].PrivateIpAddress");
				eipAddress.InstanceRegionId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceRegionId");
				eipAddress.DeletionProtection = _ctx.BooleanValue("DescribeEipAddresses.EipAddresses["+ i +"].DeletionProtection");
				eipAddress.InstanceId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceId");
				eipAddress.SecondLimited = _ctx.BooleanValue("DescribeEipAddresses.EipAddresses["+ i +"].SecondLimited");
				eipAddress.InstanceType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceType");
				eipAddress.HDMonitorStatus = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].HDMonitorStatus");
				eipAddress.RegionId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].RegionId");
				eipAddress.BandwidthPackageBandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageBandwidth");
				eipAddress.ServiceManaged = _ctx.IntegerValue("DescribeEipAddresses.EipAddresses["+ i +"].ServiceManaged");
				eipAddress.ExpiredTime = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ExpiredTime");
				eipAddress.ResourceGroupId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ResourceGroupId");
				eipAddress.AllocationId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationId");
				eipAddress.InternetChargeType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InternetChargeType");
				eipAddress.BusinessStatus = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BusinessStatus");
				eipAddress.BandwidthPackageType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageType");
				eipAddress.HasReservationData = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].HasReservationData");
				eipAddress.ISP = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ISP");
				eipAddress.PublicIpAddressPoolId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].PublicIpAddressPoolId");

				List<string> eipAddress_availableRegions = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEipAddresses.EipAddresses["+ i +"].AvailableRegions.Length"); j++) {
					eipAddress_availableRegions.Add(_ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AvailableRegions["+ j +"]"));
				}
				eipAddress.AvailableRegions = eipAddress_availableRegions;

				List<string> eipAddress_securityProtectionTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEipAddresses.EipAddresses["+ i +"].SecurityProtectionTypes.Length"); j++) {
					eipAddress_securityProtectionTypes.Add(_ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].SecurityProtectionTypes["+ j +"]"));
				}
				eipAddress.SecurityProtectionTypes = eipAddress_securityProtectionTypes;

				List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason> eipAddress_operationLocks = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason>();
				for (int j = 0; j < _ctx.Length("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks.Length"); j++) {
					DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason lockReason = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason();
					lockReason.LockReason = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks["+ j +"].LockReason");

					eipAddress_operationLocks.Add(lockReason);
				}
				eipAddress.OperationLocks = eipAddress_operationLocks;

				List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag> eipAddress_tags = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeEipAddresses.EipAddresses["+ i +"].Tags.Length"); j++) {
					DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag tag = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag();
					tag.Key = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Tags["+ j +"].Value");

					eipAddress_tags.Add(tag);
				}
				eipAddress.Tags = eipAddress_tags;

				describeEipAddressesResponse_eipAddresses.Add(eipAddress);
			}
			describeEipAddressesResponse.EipAddresses = describeEipAddressesResponse_eipAddresses;
        
			return describeEipAddressesResponse;
        }
    }
}

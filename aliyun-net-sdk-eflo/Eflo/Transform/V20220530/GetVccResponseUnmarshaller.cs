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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetVccResponseUnmarshaller
    {
        public static GetVccResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVccResponse getVccResponse = new GetVccResponse();

			getVccResponse.HttpResponse = _ctx.HttpResponse;
			getVccResponse.Code = _ctx.IntegerValue("GetVcc.Code");
			getVccResponse.Message = _ctx.StringValue("GetVcc.Message");
			getVccResponse.RequestId = _ctx.StringValue("GetVcc.RequestId");

			GetVccResponse.GetVcc_Content content = new GetVccResponse.GetVcc_Content();
			content.TenantId = _ctx.StringValue("GetVcc.Content.TenantId");
			content.RegionId = _ctx.StringValue("GetVcc.Content.RegionId");
			content.VccId = _ctx.StringValue("GetVcc.Content.VccId");
			content.VpdId = _ctx.StringValue("GetVcc.Content.VpdId");
			content.VpcId = _ctx.StringValue("GetVcc.Content.VpcId");
			content.VSwitchId = _ctx.StringValue("GetVcc.Content.VSwitchId");
			content.CenId = _ctx.StringValue("GetVcc.Content.CenId");
			content.VccName = _ctx.StringValue("GetVcc.Content.VccName");
			content.AccessPointId = _ctx.StringValue("GetVcc.Content.AccessPointId");
			content.LineOperator = _ctx.StringValue("GetVcc.Content.LineOperator");
			content.Spec = _ctx.StringValue("GetVcc.Content.Spec");
			content.PortType = _ctx.StringValue("GetVcc.Content.PortType");
			content.PricingCycle = _ctx.StringValue("GetVcc.Content.PricingCycle");
			content.PayType = _ctx.StringValue("GetVcc.Content.PayType");
			content.Duration = _ctx.StringValue("GetVcc.Content.Duration");
			content.Status = _ctx.StringValue("GetVcc.Content.Status");
			content.CurrentNode = _ctx.StringValue("GetVcc.Content.CurrentNode");
			content.InternetChargeType = _ctx.StringValue("GetVcc.Content.InternetChargeType");
			content.BandwidthStr = _ctx.StringValue("GetVcc.Content.BandwidthStr");
			content.Message = _ctx.StringValue("GetVcc.Content.Message");
			content.CreateTime = _ctx.StringValue("GetVcc.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetVcc.Content.GmtModified");
			content.CommodityCode = _ctx.StringValue("GetVcc.Content.CommodityCode");
			content.BgpCidr = _ctx.StringValue("GetVcc.Content.BgpCidr");

			GetVccResponse.GetVcc_Content.GetVcc_VpdBaseInfo vpdBaseInfo = new GetVccResponse.GetVcc_Content.GetVcc_VpdBaseInfo();
			vpdBaseInfo.VpdId = _ctx.StringValue("GetVcc.Content.VpdBaseInfo.VpdId");
			vpdBaseInfo.Name = _ctx.StringValue("GetVcc.Content.VpdBaseInfo.Name");
			vpdBaseInfo.Cidr = _ctx.StringValue("GetVcc.Content.VpdBaseInfo.Cidr");
			vpdBaseInfo.GmtCreate = _ctx.StringValue("GetVcc.Content.VpdBaseInfo.GmtCreate");
			content.VpdBaseInfo = vpdBaseInfo;

			List<GetVccResponse.GetVcc_Content.GetVcc_AliyunRouterInfoItem> content_aliyunRouterInfo = new List<GetVccResponse.GetVcc_Content.GetVcc_AliyunRouterInfoItem>();
			for (int i = 0; i < _ctx.Length("GetVcc.Content.AliyunRouterInfo.Length"); i++) {
				GetVccResponse.GetVcc_Content.GetVcc_AliyunRouterInfoItem aliyunRouterInfoItem = new GetVccResponse.GetVcc_Content.GetVcc_AliyunRouterInfoItem();
				aliyunRouterInfoItem.PcId = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].PcId");
				aliyunRouterInfoItem.VbrId = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].VbrId");
				aliyunRouterInfoItem.LocalGatewayIp = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].LocalGatewayIp");
				aliyunRouterInfoItem.PeerGatewayIp = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].PeerGatewayIp");
				aliyunRouterInfoItem.Mask = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].Mask");
				aliyunRouterInfoItem.VlanId = _ctx.StringValue("GetVcc.Content.AliyunRouterInfo["+ i +"].VlanId");

				content_aliyunRouterInfo.Add(aliyunRouterInfoItem);
			}
			content.AliyunRouterInfo = content_aliyunRouterInfo;

			List<GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem> content_cisRouterInfo = new List<GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem>();
			for (int i = 0; i < _ctx.Length("GetVcc.Content.CisRouterInfo.Length"); i++) {
				GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem cisRouterInfoItem = new GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem();
				cisRouterInfoItem.CcrId = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcrId");

				List<GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem.GetVcc_CcInfo> cisRouterInfoItem_ccInfos = new List<GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem.GetVcc_CcInfo>();
				for (int j = 0; j < _ctx.Length("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos.Length"); j++) {
					GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem.GetVcc_CcInfo ccInfo = new GetVccResponse.GetVcc_Content.GetVcc_CisRouterInfoItem.GetVcc_CcInfo();
					ccInfo.CcId = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].CcId");
					ccInfo.VlanId = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].VlanId");
					ccInfo.LocalGatewayIp = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].LocalGatewayIp");
					ccInfo.RemoteGatewayIp = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].RemoteGatewayIp");
					ccInfo.SubnetMask = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].SubnetMask");
					ccInfo.Status = _ctx.StringValue("GetVcc.Content.CisRouterInfo["+ i +"].CcInfos["+ j +"].Status");

					cisRouterInfoItem_ccInfos.Add(ccInfo);
				}
				cisRouterInfoItem.CcInfos = cisRouterInfoItem_ccInfos;

				content_cisRouterInfo.Add(cisRouterInfoItem);
			}
			content.CisRouterInfo = content_cisRouterInfo;
			getVccResponse.Content = content;
        
			return getVccResponse;
        }
    }
}

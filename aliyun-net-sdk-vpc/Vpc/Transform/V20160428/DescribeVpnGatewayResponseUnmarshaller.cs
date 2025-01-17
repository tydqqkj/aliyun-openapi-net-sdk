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
    public class DescribeVpnGatewayResponseUnmarshaller
    {
        public static DescribeVpnGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnGatewayResponse describeVpnGatewayResponse = new DescribeVpnGatewayResponse();

			describeVpnGatewayResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnGatewayResponse.VpnType = _ctx.StringValue("DescribeVpnGateway.VpnType");
			describeVpnGatewayResponse.Status = _ctx.StringValue("DescribeVpnGateway.Status");
			describeVpnGatewayResponse.VpcId = _ctx.StringValue("DescribeVpnGateway.VpcId");
			describeVpnGatewayResponse.SslMaxConnections = _ctx.LongValue("DescribeVpnGateway.SslMaxConnections");
			describeVpnGatewayResponse.Spec = _ctx.StringValue("DescribeVpnGateway.Spec");
			describeVpnGatewayResponse.InternetIp = _ctx.StringValue("DescribeVpnGateway.InternetIp");
			describeVpnGatewayResponse.CreateTime = _ctx.LongValue("DescribeVpnGateway.CreateTime");
			describeVpnGatewayResponse.AutoPropagate = _ctx.BooleanValue("DescribeVpnGateway.AutoPropagate");
			describeVpnGatewayResponse.ChargeType = _ctx.StringValue("DescribeVpnGateway.ChargeType");
			describeVpnGatewayResponse.VpnGatewayId = _ctx.StringValue("DescribeVpnGateway.VpnGatewayId");
			describeVpnGatewayResponse.Tag = _ctx.StringValue("DescribeVpnGateway.Tag");
			describeVpnGatewayResponse.IpsecVpn = _ctx.StringValue("DescribeVpnGateway.IpsecVpn");
			describeVpnGatewayResponse.EndTime = _ctx.LongValue("DescribeVpnGateway.EndTime");
			describeVpnGatewayResponse.VSwitchId = _ctx.StringValue("DescribeVpnGateway.VSwitchId");
			describeVpnGatewayResponse.RequestId = _ctx.StringValue("DescribeVpnGateway.RequestId");
			describeVpnGatewayResponse.Description = _ctx.StringValue("DescribeVpnGateway.Description");
			describeVpnGatewayResponse.EnableBgp = _ctx.BooleanValue("DescribeVpnGateway.EnableBgp");
			describeVpnGatewayResponse.BusinessStatus = _ctx.StringValue("DescribeVpnGateway.BusinessStatus");
			describeVpnGatewayResponse.SslVpn = _ctx.StringValue("DescribeVpnGateway.SslVpn");
			describeVpnGatewayResponse.Name = _ctx.StringValue("DescribeVpnGateway.Name");

			DescribeVpnGatewayResponse.DescribeVpnGateway_ReservationData reservationData = new DescribeVpnGatewayResponse.DescribeVpnGateway_ReservationData();
			reservationData.Status = _ctx.StringValue("DescribeVpnGateway.ReservationData.Status");
			reservationData.ReservationOrderType = _ctx.StringValue("DescribeVpnGateway.ReservationData.ReservationOrderType");
			reservationData.ReservationIpsec = _ctx.StringValue("DescribeVpnGateway.ReservationData.ReservationIpsec");
			reservationData.ReservationSpec = _ctx.StringValue("DescribeVpnGateway.ReservationData.ReservationSpec");
			reservationData.ReservationSsl = _ctx.StringValue("DescribeVpnGateway.ReservationData.ReservationSsl");
			reservationData.ReservationMaxConnections = _ctx.IntegerValue("DescribeVpnGateway.ReservationData.ReservationMaxConnections");
			reservationData.ReservationEndTime = _ctx.StringValue("DescribeVpnGateway.ReservationData.ReservationEndTime");
			describeVpnGatewayResponse.ReservationData = reservationData;

			List<DescribeVpnGatewayResponse.DescribeVpnGateway_Tag> describeVpnGatewayResponse_tags = new List<DescribeVpnGatewayResponse.DescribeVpnGateway_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeVpnGateway.Tags.Length"); i++) {
				DescribeVpnGatewayResponse.DescribeVpnGateway_Tag tag = new DescribeVpnGatewayResponse.DescribeVpnGateway_Tag();
				tag.Key = _ctx.StringValue("DescribeVpnGateway.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeVpnGateway.Tags["+ i +"].Value");

				describeVpnGatewayResponse_tags.Add(tag);
			}
			describeVpnGatewayResponse.Tags = describeVpnGatewayResponse_tags;
        
			return describeVpnGatewayResponse;
        }
    }
}

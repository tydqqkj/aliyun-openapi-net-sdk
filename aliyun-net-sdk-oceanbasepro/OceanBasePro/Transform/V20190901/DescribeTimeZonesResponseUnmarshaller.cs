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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeTimeZonesResponseUnmarshaller
    {
        public static DescribeTimeZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTimeZonesResponse describeTimeZonesResponse = new DescribeTimeZonesResponse();

			describeTimeZonesResponse.HttpResponse = _ctx.HttpResponse;
			describeTimeZonesResponse.RequestId = _ctx.StringValue("DescribeTimeZones.RequestId");

			DescribeTimeZonesResponse.DescribeTimeZones_TimeZones timeZones = new DescribeTimeZonesResponse.DescribeTimeZones_TimeZones();
			timeZones._Default = _ctx.StringValue("DescribeTimeZones.TimeZones.Default");

			List<DescribeTimeZonesResponse.DescribeTimeZones_TimeZones.DescribeTimeZones_ListItem> timeZones_list = new List<DescribeTimeZonesResponse.DescribeTimeZones_TimeZones.DescribeTimeZones_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeTimeZones.TimeZones.List.Length"); i++) {
				DescribeTimeZonesResponse.DescribeTimeZones_TimeZones.DescribeTimeZones_ListItem listItem = new DescribeTimeZonesResponse.DescribeTimeZones_TimeZones.DescribeTimeZones_ListItem();
				listItem.TimeZone = _ctx.StringValue("DescribeTimeZones.TimeZones.List["+ i +"].TimeZone");
				listItem.Description = _ctx.StringValue("DescribeTimeZones.TimeZones.List["+ i +"].Description");

				timeZones_list.Add(listItem);
			}
			timeZones.List = timeZones_list;
			describeTimeZonesResponse.TimeZones = timeZones;
        
			return describeTimeZonesResponse;
        }
    }
}

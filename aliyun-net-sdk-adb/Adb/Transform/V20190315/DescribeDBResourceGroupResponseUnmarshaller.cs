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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBResourceGroupResponseUnmarshaller
    {
        public static DescribeDBResourceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBResourceGroupResponse describeDBResourceGroupResponse = new DescribeDBResourceGroupResponse();

			describeDBResourceGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeDBResourceGroupResponse.RequestId = _ctx.StringValue("DescribeDBResourceGroup.RequestId");

			List<DescribeDBResourceGroupResponse.DescribeDBResourceGroup_PoolInfo> describeDBResourceGroupResponse_groupsInfo = new List<DescribeDBResourceGroupResponse.DescribeDBResourceGroup_PoolInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBResourceGroup.GroupsInfo.Length"); i++) {
				DescribeDBResourceGroupResponse.DescribeDBResourceGroup_PoolInfo poolInfo = new DescribeDBResourceGroupResponse.DescribeDBResourceGroup_PoolInfo();
				poolInfo.GroupType = _ctx.StringValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].GroupType");
				poolInfo.UpdateTime = _ctx.StringValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].UpdateTime");
				poolInfo.GroupName = _ctx.StringValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].GroupName");
				poolInfo.CreateTime = _ctx.StringValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].CreateTime");
				poolInfo.GroupUsers = _ctx.StringValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].GroupUsers");
				poolInfo.NodeNum = _ctx.IntegerValue("DescribeDBResourceGroup.GroupsInfo["+ i +"].NodeNum");

				describeDBResourceGroupResponse_groupsInfo.Add(poolInfo);
			}
			describeDBResourceGroupResponse.GroupsInfo = describeDBResourceGroupResponse_groupsInfo;
        
			return describeDBResourceGroupResponse;
        }
    }
}

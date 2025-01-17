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
    public class DescribeDBClustersResponseUnmarshaller
    {
        public static DescribeDBClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClustersResponse describeDBClustersResponse = new DescribeDBClustersResponse();

			describeDBClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClustersResponse.TotalCount = _ctx.IntegerValue("DescribeDBClusters.TotalCount");
			describeDBClustersResponse.PageSize = _ctx.IntegerValue("DescribeDBClusters.PageSize");
			describeDBClustersResponse.RequestId = _ctx.StringValue("DescribeDBClusters.RequestId");
			describeDBClustersResponse.PageNumber = _ctx.IntegerValue("DescribeDBClusters.PageNumber");

			List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster> describeDBClustersResponse_items = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusters.Items.Length"); i++) {
				DescribeDBClustersResponse.DescribeDBClusters_DBCluster dBCluster = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster();
				dBCluster.DtsJobId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DtsJobId");
				dBCluster.DBNodeCount = _ctx.LongValue("DescribeDBClusters.Items["+ i +"].DBNodeCount");
				dBCluster.Expired = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Expired");
				dBCluster.CreateTime = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].CreateTime");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].PayType");
				dBCluster.DiskType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DiskType");
				dBCluster.Mode = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Mode");
				dBCluster.Port = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Port");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].LockMode");
				dBCluster.StorageResource = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].StorageResource");
				dBCluster.ExecutorCount = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ExecutorCount");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterId");
				dBCluster.ConnectionString = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ConnectionString");
				dBCluster.RdsInstanceId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].RdsInstanceId");
				dBCluster.DBClusterType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterType");
				dBCluster.CommodityCode = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].CommodityCode");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ExpireTime");
				dBCluster.DBNodeStorage = _ctx.LongValue("DescribeDBClusters.Items["+ i +"].DBNodeStorage");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodeClass");
				dBCluster.LockReason = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].LockReason");
				dBCluster.VPCId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].VPCId");
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].RegionId");
				dBCluster.ComputeResource = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ComputeResource");
				dBCluster.ElasticIOResource = _ctx.IntegerValue("DescribeDBClusters.Items["+ i +"].ElasticIOResource");
				dBCluster.VSwitchId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].VSwitchId");
				dBCluster.DBVersion = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBVersion");
				dBCluster.VPCCloudInstanceId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].VPCCloudInstanceId");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterStatus");
				dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ResourceGroupId");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterNetworkType");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterDescription");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ZoneId");
				dBCluster.Category = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Category");
				dBCluster.Engine = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Engine");

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag> dBCluster_tags = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusters.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag tag = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag();
					tag.Key = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Value");

					dBCluster_tags.Add(tag);
				}
				dBCluster.Tags = dBCluster_tags;

				describeDBClustersResponse_items.Add(dBCluster);
			}
			describeDBClustersResponse.Items = describeDBClustersResponse_items;
        
			return describeDBClustersResponse;
        }
    }
}

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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDBClustersResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<DescribeDBClusters_DBCluster> items;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeDBClusters_DBCluster> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBClusters_DBCluster
		{

			private string dtsJobId;

			private long? dBNodeCount;

			private string expired;

			private string createTime;

			private string payType;

			private string diskType;

			private string mode;

			private string port;

			private string lockMode;

			private string storageResource;

			private string executorCount;

			private string dBClusterId;

			private string connectionString;

			private string rdsInstanceId;

			private string dBClusterType;

			private string commodityCode;

			private string expireTime;

			private long? dBNodeStorage;

			private string dBNodeClass;

			private string lockReason;

			private string vPCId;

			private string regionId;

			private string computeResource;

			private int? elasticIOResource;

			private string vSwitchId;

			private string dBVersion;

			private string vPCCloudInstanceId;

			private string dBClusterStatus;

			private string resourceGroupId;

			private string dBClusterNetworkType;

			private string dBClusterDescription;

			private string zoneId;

			private string category;

			private string engine;

			private List<DescribeDBClusters_Tag> tags;

			public string DtsJobId
			{
				get
				{
					return dtsJobId;
				}
				set	
				{
					dtsJobId = value;
				}
			}

			public long? DBNodeCount
			{
				get
				{
					return dBNodeCount;
				}
				set	
				{
					dBNodeCount = value;
				}
			}

			public string Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			public string StorageResource
			{
				get
				{
					return storageResource;
				}
				set	
				{
					storageResource = value;
				}
			}

			public string ExecutorCount
			{
				get
				{
					return executorCount;
				}
				set	
				{
					executorCount = value;
				}
			}

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
				}
			}

			public string ConnectionString
			{
				get
				{
					return connectionString;
				}
				set	
				{
					connectionString = value;
				}
			}

			public string RdsInstanceId
			{
				get
				{
					return rdsInstanceId;
				}
				set	
				{
					rdsInstanceId = value;
				}
			}

			public string DBClusterType
			{
				get
				{
					return dBClusterType;
				}
				set	
				{
					dBClusterType = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public long? DBNodeStorage
			{
				get
				{
					return dBNodeStorage;
				}
				set	
				{
					dBNodeStorage = value;
				}
			}

			public string DBNodeClass
			{
				get
				{
					return dBNodeClass;
				}
				set	
				{
					dBNodeClass = value;
				}
			}

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}

			public string VPCId
			{
				get
				{
					return vPCId;
				}
				set	
				{
					vPCId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ComputeResource
			{
				get
				{
					return computeResource;
				}
				set	
				{
					computeResource = value;
				}
			}

			public int? ElasticIOResource
			{
				get
				{
					return elasticIOResource;
				}
				set	
				{
					elasticIOResource = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string DBVersion
			{
				get
				{
					return dBVersion;
				}
				set	
				{
					dBVersion = value;
				}
			}

			public string VPCCloudInstanceId
			{
				get
				{
					return vPCCloudInstanceId;
				}
				set	
				{
					vPCCloudInstanceId = value;
				}
			}

			public string DBClusterStatus
			{
				get
				{
					return dBClusterStatus;
				}
				set	
				{
					dBClusterStatus = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string DBClusterNetworkType
			{
				get
				{
					return dBClusterNetworkType;
				}
				set	
				{
					dBClusterNetworkType = value;
				}
			}

			public string DBClusterDescription
			{
				get
				{
					return dBClusterDescription;
				}
				set	
				{
					dBClusterDescription = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public List<DescribeDBClusters_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeDBClusters_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}

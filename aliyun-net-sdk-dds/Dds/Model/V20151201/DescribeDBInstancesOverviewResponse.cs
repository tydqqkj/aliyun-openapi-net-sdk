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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeDBInstancesOverviewResponse : AcsResponse
	{

		private string totalCount;

		private string requestId;

		private List<DescribeDBInstancesOverview_DBInstance> dBInstances;

		public string TotalCount
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

		public List<DescribeDBInstancesOverview_DBInstance> DBInstances
		{
			get
			{
				return dBInstances;
			}
			set	
			{
				dBInstances = value;
			}
		}

		public class DescribeDBInstancesOverview_DBInstance
		{

			private string creationTime;

			private string expireTime;

			private string lastDowngradeTime;

			private string dBInstanceType;

			private string destroyTime;

			private string chargeType;

			private string capacityUnit;

			private string vpcAuthMode;

			private string dBInstanceStatus;

			private string networkType;

			private string lockMode;

			private string engineVersion;

			private string regionId;

			private int? dBInstanceStorage;

			private string resourceGroupId;

			private string zoneId;

			private string dBInstanceId;

			private string dBInstanceClass;

			private string engine;

			private string replicationFactor;

			private string dBInstanceDescription;

			private string kindCode;

			private List<DescribeDBInstancesOverview_Tag> tags;

			private List<DescribeDBInstancesOverview_ShardAttribute> shardList;

			private List<DescribeDBInstancesOverview_MongosAttribute> mongosList;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public string LastDowngradeTime
			{
				get
				{
					return lastDowngradeTime;
				}
				set	
				{
					lastDowngradeTime = value;
				}
			}

			public string DBInstanceType
			{
				get
				{
					return dBInstanceType;
				}
				set	
				{
					dBInstanceType = value;
				}
			}

			public string DestroyTime
			{
				get
				{
					return destroyTime;
				}
				set	
				{
					destroyTime = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string CapacityUnit
			{
				get
				{
					return capacityUnit;
				}
				set	
				{
					capacityUnit = value;
				}
			}

			public string VpcAuthMode
			{
				get
				{
					return vpcAuthMode;
				}
				set	
				{
					vpcAuthMode = value;
				}
			}

			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
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

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
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

			public int? DBInstanceStorage
			{
				get
				{
					return dBInstanceStorage;
				}
				set	
				{
					dBInstanceStorage = value;
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

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public string DBInstanceClass
			{
				get
				{
					return dBInstanceClass;
				}
				set	
				{
					dBInstanceClass = value;
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

			public string ReplicationFactor
			{
				get
				{
					return replicationFactor;
				}
				set	
				{
					replicationFactor = value;
				}
			}

			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}

			public string KindCode
			{
				get
				{
					return kindCode;
				}
				set	
				{
					kindCode = value;
				}
			}

			public List<DescribeDBInstancesOverview_Tag> Tags
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

			public List<DescribeDBInstancesOverview_ShardAttribute> ShardList
			{
				get
				{
					return shardList;
				}
				set	
				{
					shardList = value;
				}
			}

			public List<DescribeDBInstancesOverview_MongosAttribute> MongosList
			{
				get
				{
					return mongosList;
				}
				set	
				{
					mongosList = value;
				}
			}

			public class DescribeDBInstancesOverview_Tag
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

			public class DescribeDBInstancesOverview_ShardAttribute
			{

				private string nodeClass;

				private string nodeDescription;

				private int? nodeStorage;

				private string nodeId;

				private int? readonlyReplicas;

				public string NodeClass
				{
					get
					{
						return nodeClass;
					}
					set	
					{
						nodeClass = value;
					}
				}

				public string NodeDescription
				{
					get
					{
						return nodeDescription;
					}
					set	
					{
						nodeDescription = value;
					}
				}

				public int? NodeStorage
				{
					get
					{
						return nodeStorage;
					}
					set	
					{
						nodeStorage = value;
					}
				}

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}

				public int? ReadonlyReplicas
				{
					get
					{
						return readonlyReplicas;
					}
					set	
					{
						readonlyReplicas = value;
					}
				}
			}

			public class DescribeDBInstancesOverview_MongosAttribute
			{

				private string nodeClass;

				private string nodeDescription;

				private string nodeId;

				public string NodeClass
				{
					get
					{
						return nodeClass;
					}
					set	
					{
						nodeClass = value;
					}
				}

				public string NodeDescription
				{
					get
					{
						return nodeDescription;
					}
					set	
					{
						nodeDescription = value;
					}
				}

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}
			}
		}
	}
}

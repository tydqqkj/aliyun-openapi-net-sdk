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
	public class DescribeBackupsResponse : AcsResponse
	{

		private string totalCount;

		private string pageSize;

		private string requestId;

		private string pageNumber;

		private List<DescribeBackups_Backup> items;

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

		public string PageSize
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

		public string PageNumber
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

		public List<DescribeBackups_Backup> Items
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

		public class DescribeBackups_Backup
		{

			private string dBClusterId;

			private string backupType;

			private string backupStartTime;

			private int? backupSize;

			private string backupEndTime;

			private string backupId;

			private string backupMethod;

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

			public string BackupType
			{
				get
				{
					return backupType;
				}
				set	
				{
					backupType = value;
				}
			}

			public string BackupStartTime
			{
				get
				{
					return backupStartTime;
				}
				set	
				{
					backupStartTime = value;
				}
			}

			public int? BackupSize
			{
				get
				{
					return backupSize;
				}
				set	
				{
					backupSize = value;
				}
			}

			public string BackupEndTime
			{
				get
				{
					return backupEndTime;
				}
				set	
				{
					backupEndTime = value;
				}
			}

			public string BackupId
			{
				get
				{
					return backupId;
				}
				set	
				{
					backupId = value;
				}
			}

			public string BackupMethod
			{
				get
				{
					return backupMethod;
				}
				set	
				{
					backupMethod = value;
				}
			}
		}
	}
}

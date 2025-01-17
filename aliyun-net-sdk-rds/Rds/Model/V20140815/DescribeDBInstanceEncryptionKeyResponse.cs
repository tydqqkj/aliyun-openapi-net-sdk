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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceEncryptionKeyResponse : AcsResponse
	{

		private string deleteDate;

		private string requestId;

		private string description;

		private string origin;

		private string materialExpireTime;

		private string encryptionKeyStatus;

		private string keyUsage;

		private string encryptionKey;

		private string creator;

		[JsonProperty(PropertyName = "DeleteDate")]
		public string DeleteDate
		{
			get
			{
				return deleteDate;
			}
			set	
			{
				deleteDate = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		[JsonProperty(PropertyName = "Origin")]
		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
			}
		}

		[JsonProperty(PropertyName = "MaterialExpireTime")]
		public string MaterialExpireTime
		{
			get
			{
				return materialExpireTime;
			}
			set	
			{
				materialExpireTime = value;
			}
		}

		[JsonProperty(PropertyName = "EncryptionKeyStatus")]
		public string EncryptionKeyStatus
		{
			get
			{
				return encryptionKeyStatus;
			}
			set	
			{
				encryptionKeyStatus = value;
			}
		}

		[JsonProperty(PropertyName = "KeyUsage")]
		public string KeyUsage
		{
			get
			{
				return keyUsage;
			}
			set	
			{
				keyUsage = value;
			}
		}

		[JsonProperty(PropertyName = "EncryptionKey")]
		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
			}
		}

		[JsonProperty(PropertyName = "Creator")]
		public string Creator
		{
			get
			{
				return creator;
			}
			set	
			{
				creator = value;
			}
		}
	}
}

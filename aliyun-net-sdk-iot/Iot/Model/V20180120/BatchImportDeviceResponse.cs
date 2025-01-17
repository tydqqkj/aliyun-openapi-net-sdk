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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class BatchImportDeviceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private BatchImportDevice_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public BatchImportDevice_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class BatchImportDevice_Data
		{

			private long? applyId;

			private List<string> repeatedDeviceNameList;

			private List<string> invalidDeviceNameList;

			private List<string> invalidDeviceSecretList;

			private List<string> invalidSnList;

			public long? ApplyId
			{
				get
				{
					return applyId;
				}
				set	
				{
					applyId = value;
				}
			}

			public List<string> RepeatedDeviceNameList
			{
				get
				{
					return repeatedDeviceNameList;
				}
				set	
				{
					repeatedDeviceNameList = value;
				}
			}

			public List<string> InvalidDeviceNameList
			{
				get
				{
					return invalidDeviceNameList;
				}
				set	
				{
					invalidDeviceNameList = value;
				}
			}

			public List<string> InvalidDeviceSecretList
			{
				get
				{
					return invalidDeviceSecretList;
				}
				set	
				{
					invalidDeviceSecretList = value;
				}
			}

			public List<string> InvalidSnList
			{
				get
				{
					return invalidSnList;
				}
				set	
				{
					invalidSnList = value;
				}
			}
		}
	}
}

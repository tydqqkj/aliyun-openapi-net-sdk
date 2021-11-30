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

namespace Aliyun.Acs.UniMkt.Model.V20190724
{
	public class GetDeviceShortChainUrlResponse : AcsResponse
	{

		private string requestId;

		private bool? status;

		private string errorMessage;

		private string errorCode;

		private GetDeviceShortChainUrl_Data data;

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

		public bool? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public GetDeviceShortChainUrl_Data Data
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

		public class GetDeviceShortChainUrl_Data
		{

			private string shortImgUrl;

			private string shortUrl;

			public string ShortImgUrl
			{
				get
				{
					return shortImgUrl;
				}
				set	
				{
					shortImgUrl = value;
				}
			}

			public string ShortUrl
			{
				get
				{
					return shortUrl;
				}
				set	
				{
					shortUrl = value;
				}
			}
		}
	}
}

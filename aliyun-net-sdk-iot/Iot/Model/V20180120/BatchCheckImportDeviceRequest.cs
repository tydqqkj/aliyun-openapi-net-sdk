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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class BatchCheckImportDeviceRequest : RpcAcsRequest<BatchCheckImportDeviceResponse>
    {
        public BatchCheckImportDeviceRequest()
            : base("Iot", "2018-01-20", "BatchCheckImportDevice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private string productKey;

		private List<DeviceList> deviceLists = new List<DeviceList>(){ };

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public List<DeviceList> DeviceLists
		{
			get
			{
				return deviceLists;
			}

			set
			{
				deviceLists = value;
				for (int i = 0; i < deviceLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeviceList." + (i + 1) + ".DeviceSecret", deviceLists[i].DeviceSecret);
					DictionaryUtil.Add(QueryParameters,"DeviceList." + (i + 1) + ".DeviceName", deviceLists[i].DeviceName);
					DictionaryUtil.Add(QueryParameters,"DeviceList." + (i + 1) + ".Sn", deviceLists[i].Sn);
				}
			}
		}

		public class DeviceList
		{

			private string deviceSecret;

			private string deviceName;

			private string sn;

			public string DeviceSecret
			{
				get
				{
					return deviceSecret;
				}
				set	
				{
					deviceSecret = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
				}
			}

			public string Sn
			{
				get
				{
					return sn;
				}
				set	
				{
					sn = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchCheckImportDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchCheckImportDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

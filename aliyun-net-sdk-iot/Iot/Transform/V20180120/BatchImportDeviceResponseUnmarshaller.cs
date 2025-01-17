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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class BatchImportDeviceResponseUnmarshaller
    {
        public static BatchImportDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchImportDeviceResponse batchImportDeviceResponse = new BatchImportDeviceResponse();

			batchImportDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchImportDeviceResponse.RequestId = _ctx.StringValue("BatchImportDevice.RequestId");
			batchImportDeviceResponse.Success = _ctx.BooleanValue("BatchImportDevice.Success");
			batchImportDeviceResponse.Code = _ctx.StringValue("BatchImportDevice.Code");
			batchImportDeviceResponse.ErrorMessage = _ctx.StringValue("BatchImportDevice.ErrorMessage");

			BatchImportDeviceResponse.BatchImportDevice_Data data = new BatchImportDeviceResponse.BatchImportDevice_Data();
			data.ApplyId = _ctx.LongValue("BatchImportDevice.Data.ApplyId");

			List<string> data_repeatedDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportDevice.Data.RepeatedDeviceNameList.Length"); i++) {
				data_repeatedDeviceNameList.Add(_ctx.StringValue("BatchImportDevice.Data.RepeatedDeviceNameList["+ i +"]"));
			}
			data.RepeatedDeviceNameList = data_repeatedDeviceNameList;

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportDevice.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(_ctx.StringValue("BatchImportDevice.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_invalidDeviceSecretList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportDevice.Data.InvalidDeviceSecretList.Length"); i++) {
				data_invalidDeviceSecretList.Add(_ctx.StringValue("BatchImportDevice.Data.InvalidDeviceSecretList["+ i +"]"));
			}
			data.InvalidDeviceSecretList = data_invalidDeviceSecretList;

			List<string> data_invalidSnList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchImportDevice.Data.InvalidSnList.Length"); i++) {
				data_invalidSnList.Add(_ctx.StringValue("BatchImportDevice.Data.InvalidSnList["+ i +"]"));
			}
			data.InvalidSnList = data_invalidSnList;
			batchImportDeviceResponse.Data = data;
        
			return batchImportDeviceResponse;
        }
    }
}

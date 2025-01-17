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
    public class UpdateSpeechRequest : RpcAcsRequest<UpdateSpeechResponse>
    {
        public UpdateSpeechRequest()
            : base("Iot", "2018-01-20", "UpdateSpeech")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string voice;

		private string projectCode;

		private string iotInstanceId;

		private string soundCodeConfig;

		private bool? enableSoundCode;

		private int? volume;

		private int? speechRate;

		private string speechCode;

		public string Voice
		{
			get
			{
				return voice;
			}
			set	
			{
				voice = value;
				DictionaryUtil.Add(BodyParameters, "Voice", value);
			}
		}

		public string ProjectCode
		{
			get
			{
				return projectCode;
			}
			set	
			{
				projectCode = value;
				DictionaryUtil.Add(BodyParameters, "ProjectCode", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "IotInstanceId", value);
			}
		}

		public string SoundCodeConfig
		{
			get
			{
				return soundCodeConfig;
			}
			set	
			{
				soundCodeConfig = value;
				DictionaryUtil.Add(BodyParameters, "SoundCodeConfig", value);
			}
		}

		public bool? EnableSoundCode
		{
			get
			{
				return enableSoundCode;
			}
			set	
			{
				enableSoundCode = value;
				DictionaryUtil.Add(BodyParameters, "EnableSoundCode", value.ToString());
			}
		}

		public int? Volume
		{
			get
			{
				return volume;
			}
			set	
			{
				volume = value;
				DictionaryUtil.Add(BodyParameters, "Volume", value.ToString());
			}
		}

		public int? SpeechRate
		{
			get
			{
				return speechRate;
			}
			set	
			{
				speechRate = value;
				DictionaryUtil.Add(BodyParameters, "SpeechRate", value.ToString());
			}
		}

		public string SpeechCode
		{
			get
			{
				return speechCode;
			}
			set	
			{
				speechCode = value;
				DictionaryUtil.Add(BodyParameters, "SpeechCode", value);
			}
		}

        public override UpdateSpeechResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSpeechResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

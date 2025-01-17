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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveStreamTranscodeInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamTranscodeInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamTranscodeInfoResponse describeLiveStreamTranscodeInfoResponse = new DescribeLiveStreamTranscodeInfoResponse();

			describeLiveStreamTranscodeInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamTranscodeInfoResponse.RequestId = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.RequestId");

			List<DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> describeLiveStreamTranscodeInfoResponse_domainTranscodeList = new List<DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamTranscodeInfo.DomainTranscodeList.Length"); i++) {
				DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo domainTranscodeInfo = new DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo();
				domainTranscodeInfo.TranscodeApp = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeApp");
				domainTranscodeInfo.TranscodeTemplate = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeTemplate");
				domainTranscodeInfo.IsLazy = _ctx.BooleanValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].IsLazy");
				domainTranscodeInfo.TranscodeName = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeName");

				DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo.DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters customTranscodeParameters = new DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo.DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters();
				customTranscodeParameters.VideoProfile = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.VideoProfile");
				customTranscodeParameters.AudioBitrate = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.AudioBitrate");
				customTranscodeParameters.RtsFlag = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.RtsFlag");
				customTranscodeParameters.Height = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.Height");
				customTranscodeParameters.TemplateType = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.TemplateType");
				customTranscodeParameters.Bframes = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.Bframes");
				customTranscodeParameters.AudioRate = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.AudioRate");
				customTranscodeParameters.FPS = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.FPS");
				customTranscodeParameters.AudioCodec = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.AudioCodec");
				customTranscodeParameters.Gop = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.Gop");
				customTranscodeParameters.VideoBitrate = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.VideoBitrate");
				customTranscodeParameters.Width = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.Width");
				customTranscodeParameters.AudioChannelNum = _ctx.IntegerValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.AudioChannelNum");
				customTranscodeParameters.AudioProfile = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].CustomTranscodeParameters.AudioProfile");
				domainTranscodeInfo.CustomTranscodeParameters = customTranscodeParameters;

				DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo.DescribeLiveStreamTranscodeInfo_EncryptParameters encryptParameters = new DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo.DescribeLiveStreamTranscodeInfo_EncryptParameters();
				encryptParameters.EncryptType = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].EncryptParameters.EncryptType");
				encryptParameters.KmsKeyID = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].EncryptParameters.KmsKeyID");
				encryptParameters.KmsKeyExpireInterval = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].EncryptParameters.KmsKeyExpireInterval");
				domainTranscodeInfo.EncryptParameters = encryptParameters;

				describeLiveStreamTranscodeInfoResponse_domainTranscodeList.Add(domainTranscodeInfo);
			}
			describeLiveStreamTranscodeInfoResponse.DomainTranscodeList = describeLiveStreamTranscodeInfoResponse_domainTranscodeList;
        
			return describeLiveStreamTranscodeInfoResponse;
        }
    }
}

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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class GetCopyrightNoticeRequest : RpcAcsRequest<GetCopyrightNoticeResponse>
    {
        public GetCopyrightNoticeRequest()
            : base("Copyright", "2019-01-23", "GetCopyrightNotice")
        {
			Method = MethodType.POST;
        }

		private string bizId;

		private string fileId;

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string FileId
		{
			get
			{
				return fileId;
			}
			set	
			{
				fileId = value;
				DictionaryUtil.Add(QueryParameters, "FileId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetCopyrightNoticeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetCopyrightNoticeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class ResultCallbackRequest : RpcAcsRequest<ResultCallbackResponse>
    {
        public ResultCallbackRequest()
            : base("quickbi-public", "2022-01-01", "ResultCallback", "quickbi", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string handleReason;

		private string applicationId;

		private int? status;

		public string HandleReason
		{
			get
			{
				return handleReason;
			}
			set	
			{
				handleReason = value;
				DictionaryUtil.Add(QueryParameters, "HandleReason", value);
			}
		}

		public string ApplicationId
		{
			get
			{
				return applicationId;
			}
			set	
			{
				applicationId = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationId", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ResultCallbackResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResultCallbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

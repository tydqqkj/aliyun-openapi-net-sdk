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
    public class DeletePatentPlanRequest : RpcAcsRequest<DeletePatentPlanResponse>
    {
        public DeletePatentPlanRequest()
            : base("Copyright", "2019-01-23", "DeletePatentPlan")
        {
			Method = MethodType.POST;
        }

		private bool? deletePlanDetail;

		private long? planId;

		public bool? DeletePlanDetail
		{
			get
			{
				return deletePlanDetail;
			}
			set	
			{
				deletePlanDetail = value;
				DictionaryUtil.Add(QueryParameters, "DeletePlanDetail", value.ToString());
			}
		}

		public long? PlanId
		{
			get
			{
				return planId;
			}
			set	
			{
				planId = value;
				DictionaryUtil.Add(QueryParameters, "PlanId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeletePatentPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeletePatentPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class SaveBaseStrategyPeriodRequest : RpcAcsRequest<SaveBaseStrategyPeriodResponse>
    {
        public SaveBaseStrategyPeriodRequest()
            : base("OutboundBot", "2019-12-26", "SaveBaseStrategyPeriod", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? strategyLevel;

		private string entryId;

		private bool? onlyWeekdays;

		private string workingTimeFramesJson;

		private List<string> workingTimes = new List<string>(){ };

		public int? StrategyLevel
		{
			get
			{
				return strategyLevel;
			}
			set	
			{
				strategyLevel = value;
				DictionaryUtil.Add(QueryParameters, "StrategyLevel", value.ToString());
			}
		}

		public string EntryId
		{
			get
			{
				return entryId;
			}
			set	
			{
				entryId = value;
				DictionaryUtil.Add(QueryParameters, "EntryId", value);
			}
		}

		public bool? OnlyWeekdays
		{
			get
			{
				return onlyWeekdays;
			}
			set	
			{
				onlyWeekdays = value;
				DictionaryUtil.Add(QueryParameters, "OnlyWeekdays", value.ToString());
			}
		}

		public string WorkingTimeFramesJson
		{
			get
			{
				return workingTimeFramesJson;
			}
			set	
			{
				workingTimeFramesJson = value;
				DictionaryUtil.Add(QueryParameters, "WorkingTimeFramesJson", value);
			}
		}

		public List<string> WorkingTimes
		{
			get
			{
				return workingTimes;
			}

			set
			{
				workingTimes = value;
			}
		}

        public override SaveBaseStrategyPeriodResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBaseStrategyPeriodResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

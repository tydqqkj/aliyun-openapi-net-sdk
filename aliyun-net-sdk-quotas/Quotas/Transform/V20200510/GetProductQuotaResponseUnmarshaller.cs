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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class GetProductQuotaResponseUnmarshaller
    {
        public static GetProductQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProductQuotaResponse getProductQuotaResponse = new GetProductQuotaResponse();

			getProductQuotaResponse.HttpResponse = _ctx.HttpResponse;
			getProductQuotaResponse.RequestId = _ctx.StringValue("GetProductQuota.RequestId");

			GetProductQuotaResponse.GetProductQuota_Quota quota = new GetProductQuotaResponse.GetProductQuota_Quota();
			quota.QuotaUnit = _ctx.StringValue("GetProductQuota.Quota.QuotaUnit");
			quota.QuotaActionCode = _ctx.StringValue("GetProductQuota.Quota.QuotaActionCode");
			quota.TotalUsage = _ctx.FloatValue("GetProductQuota.Quota.TotalUsage");
			quota.QuotaType = _ctx.StringValue("GetProductQuota.Quota.QuotaType");
			quota.QuotaDescription = _ctx.StringValue("GetProductQuota.Quota.QuotaDescription");
			quota.QuotaArn = _ctx.StringValue("GetProductQuota.Quota.QuotaArn");
			quota.ApplicableType = _ctx.StringValue("GetProductQuota.Quota.ApplicableType");
			quota.Dimensions = _ctx.StringValue("GetProductQuota.Quota.Dimensions");
			quota.Adjustable = _ctx.BooleanValue("GetProductQuota.Quota.Adjustable");
			quota.QuotaName = _ctx.StringValue("GetProductQuota.Quota.QuotaName");
			quota.UnadjustableDetail = _ctx.StringValue("GetProductQuota.Quota.UnadjustableDetail");
			quota.Consumable = _ctx.BooleanValue("GetProductQuota.Quota.Consumable");
			quota.TotalQuota = _ctx.FloatValue("GetProductQuota.Quota.TotalQuota");
			quota.ProductCode = _ctx.StringValue("GetProductQuota.Quota.ProductCode");
			quota.EffectiveTime = _ctx.StringValue("GetProductQuota.Quota.EffectiveTime");
			quota.ExpireTime = _ctx.StringValue("GetProductQuota.Quota.ExpireTime");
			quota.QuotaCategory = _ctx.StringValue("GetProductQuota.Quota.QuotaCategory");

			List<string> quota_applicableRange = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProductQuota.Quota.ApplicableRange.Length"); i++) {
				quota_applicableRange.Add(_ctx.StringValue("GetProductQuota.Quota.ApplicableRange["+ i +"]"));
			}
			quota.ApplicableRange = quota_applicableRange;

			List<string> quota_supportedRange = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProductQuota.Quota.SupportedRange.Length"); i++) {
				quota_supportedRange.Add(_ctx.StringValue("GetProductQuota.Quota.SupportedRange["+ i +"]"));
			}
			quota.SupportedRange = quota_supportedRange;

			GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_Period period = new GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_Period();
			period.PeriodValue = _ctx.IntegerValue("GetProductQuota.Quota.Period.PeriodValue");
			period.PeriodUnit = _ctx.StringValue("GetProductQuota.Quota.Period.PeriodUnit");
			quota.Period = period;

			List<GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_QuotaItemsItem> quota_quotaItems = new List<GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_QuotaItemsItem>();
			for (int i = 0; i < _ctx.Length("GetProductQuota.Quota.QuotaItems.Length"); i++) {
				GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_QuotaItemsItem quotaItemsItem = new GetProductQuotaResponse.GetProductQuota_Quota.GetProductQuota_QuotaItemsItem();
				quotaItemsItem.Type = _ctx.StringValue("GetProductQuota.Quota.QuotaItems["+ i +"].Type");
				quotaItemsItem.Quota = _ctx.StringValue("GetProductQuota.Quota.QuotaItems["+ i +"].Quota");
				quotaItemsItem.QuotaUnit = _ctx.StringValue("GetProductQuota.Quota.QuotaItems["+ i +"].QuotaUnit");
				quotaItemsItem.Usage = _ctx.StringValue("GetProductQuota.Quota.QuotaItems["+ i +"].Usage");

				quota_quotaItems.Add(quotaItemsItem);
			}
			quota.QuotaItems = quota_quotaItems;
			getProductQuotaResponse.Quota = quota;
        
			return getProductQuotaResponse;
        }
    }
}

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
    public class ListProductQuotasResponseUnmarshaller
    {
        public static ListProductQuotasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProductQuotasResponse listProductQuotasResponse = new ListProductQuotasResponse();

			listProductQuotasResponse.HttpResponse = _ctx.HttpResponse;
			listProductQuotasResponse.TotalCount = _ctx.IntegerValue("ListProductQuotas.TotalCount");
			listProductQuotasResponse.NextToken = _ctx.StringValue("ListProductQuotas.NextToken");
			listProductQuotasResponse.RequestId = _ctx.StringValue("ListProductQuotas.RequestId");
			listProductQuotasResponse.MaxResults = _ctx.IntegerValue("ListProductQuotas.MaxResults");

			List<ListProductQuotasResponse.ListProductQuotas_QuotasItem> listProductQuotasResponse_quotas = new List<ListProductQuotasResponse.ListProductQuotas_QuotasItem>();
			for (int i = 0; i < _ctx.Length("ListProductQuotas.Quotas.Length"); i++) {
				ListProductQuotasResponse.ListProductQuotas_QuotasItem quotasItem = new ListProductQuotasResponse.ListProductQuotas_QuotasItem();
				quotasItem.QuotaUnit = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaUnit");
				quotasItem.QuotaActionCode = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaActionCode");
				quotasItem.TotalUsage = _ctx.FloatValue("ListProductQuotas.Quotas["+ i +"].TotalUsage");
				quotasItem.QuotaType = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaType");
				quotasItem.QuotaDescription = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaDescription");
				quotasItem.QuotaArn = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaArn");
				quotasItem.ApplicableType = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].ApplicableType");
				quotasItem.Dimensions = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].Dimensions");
				quotasItem.Adjustable = _ctx.BooleanValue("ListProductQuotas.Quotas["+ i +"].Adjustable");
				quotasItem.QuotaName = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaName");
				quotasItem.UnadjustableDetail = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].UnadjustableDetail");
				quotasItem.Consumable = _ctx.BooleanValue("ListProductQuotas.Quotas["+ i +"].Consumable");
				quotasItem.TotalQuota = _ctx.FloatValue("ListProductQuotas.Quotas["+ i +"].TotalQuota");
				quotasItem.ProductCode = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].ProductCode");
				quotasItem.EffectiveTime = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].EffectiveTime");
				quotasItem.ExpireTime = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].ExpireTime");
				quotasItem.QuotaCategory = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaCategory");

				List<string> quotasItem_applicableRange = new List<string>();
				for (int j = 0; j < _ctx.Length("ListProductQuotas.Quotas["+ i +"].ApplicableRange.Length"); j++) {
					quotasItem_applicableRange.Add(_ctx.StringValue("ListProductQuotas.Quotas["+ i +"].ApplicableRange["+ j +"]"));
				}
				quotasItem.ApplicableRange = quotasItem_applicableRange;

				List<string> quotasItem_supportedRange = new List<string>();
				for (int j = 0; j < _ctx.Length("ListProductQuotas.Quotas["+ i +"].SupportedRange.Length"); j++) {
					quotasItem_supportedRange.Add(_ctx.StringValue("ListProductQuotas.Quotas["+ i +"].SupportedRange["+ j +"]"));
				}
				quotasItem.SupportedRange = quotasItem_supportedRange;

				ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_Period period = new ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_Period();
				period.PeriodValue = _ctx.IntegerValue("ListProductQuotas.Quotas["+ i +"].Period.PeriodValue");
				period.PeriodUnit = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].Period.PeriodUnit");
				quotasItem.Period = period;

				List<ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_QuotaItemsItem> quotasItem_quotaItems = new List<ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_QuotaItemsItem>();
				for (int j = 0; j < _ctx.Length("ListProductQuotas.Quotas["+ i +"].QuotaItems.Length"); j++) {
					ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_QuotaItemsItem quotaItemsItem = new ListProductQuotasResponse.ListProductQuotas_QuotasItem.ListProductQuotas_QuotaItemsItem();
					quotaItemsItem.Type = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaItems["+ j +"].Type");
					quotaItemsItem.Quota = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaItems["+ j +"].Quota");
					quotaItemsItem.QuotaUnit = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaItems["+ j +"].QuotaUnit");
					quotaItemsItem.Usage = _ctx.StringValue("ListProductQuotas.Quotas["+ i +"].QuotaItems["+ j +"].Usage");

					quotasItem_quotaItems.Add(quotaItemsItem);
				}
				quotasItem.QuotaItems = quotasItem_quotaItems;

				listProductQuotasResponse_quotas.Add(quotasItem);
			}
			listProductQuotasResponse.Quotas = listProductQuotasResponse_quotas;
        
			return listProductQuotasResponse;
        }
    }
}

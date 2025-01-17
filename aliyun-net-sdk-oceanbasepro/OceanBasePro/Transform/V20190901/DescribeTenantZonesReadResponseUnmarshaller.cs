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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeTenantZonesReadResponseUnmarshaller
    {
        public static DescribeTenantZonesReadResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantZonesReadResponse describeTenantZonesReadResponse = new DescribeTenantZonesReadResponse();

			describeTenantZonesReadResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantZonesReadResponse.RequestId = _ctx.StringValue("DescribeTenantZonesRead.RequestId");

			List<DescribeTenantZonesReadResponse.DescribeTenantZonesRead_TenantZonesItem> describeTenantZonesReadResponse_tenantZones = new List<DescribeTenantZonesReadResponse.DescribeTenantZonesRead_TenantZonesItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantZonesRead.TenantZones.Length"); i++) {
				DescribeTenantZonesReadResponse.DescribeTenantZonesRead_TenantZonesItem tenantZonesItem = new DescribeTenantZonesReadResponse.DescribeTenantZonesRead_TenantZonesItem();
				tenantZonesItem.IsElectable = _ctx.BooleanValue("DescribeTenantZonesRead.TenantZones["+ i +"].IsElectable");
				tenantZonesItem.IsPrimary = _ctx.BooleanValue("DescribeTenantZonesRead.TenantZones["+ i +"].IsPrimary");
				tenantZonesItem.Zone = _ctx.StringValue("DescribeTenantZonesRead.TenantZones["+ i +"].Zone");
				tenantZonesItem.IsReadOnlyAddressMaster = _ctx.BooleanValue("DescribeTenantZonesRead.TenantZones["+ i +"].IsReadOnlyAddressMaster");
				tenantZonesItem.IsReadable = _ctx.StringValue("DescribeTenantZonesRead.TenantZones["+ i +"].IsReadable");

				describeTenantZonesReadResponse_tenantZones.Add(tenantZonesItem);
			}
			describeTenantZonesReadResponse.TenantZones = describeTenantZonesReadResponse_tenantZones;
        
			return describeTenantZonesReadResponse;
        }
    }
}

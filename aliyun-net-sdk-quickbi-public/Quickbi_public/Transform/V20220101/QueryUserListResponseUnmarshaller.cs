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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryUserListResponseUnmarshaller
    {
        public static QueryUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserListResponse queryUserListResponse = new QueryUserListResponse();

			queryUserListResponse.HttpResponse = _ctx.HttpResponse;
			queryUserListResponse.Success = _ctx.BooleanValue("QueryUserList.Success");
			queryUserListResponse.RequestId = _ctx.StringValue("QueryUserList.RequestId");

			QueryUserListResponse.QueryUserList_Result result = new QueryUserListResponse.QueryUserList_Result();
			result.TotalPages = _ctx.IntegerValue("QueryUserList.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("QueryUserList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryUserList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryUserList.Result.TotalNum");

			List<QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem> result_data = new List<QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryUserList.Result.Data.Length"); i++) {
				QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem dataItem = new QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem();
				dataItem.UserType = _ctx.IntegerValue("QueryUserList.Result.Data["+ i +"].UserType");
				dataItem.Email = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].Email");
				dataItem.UserId = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].UserId");
				dataItem.AuthAdminUser = _ctx.BooleanValue("QueryUserList.Result.Data["+ i +"].AuthAdminUser");
				dataItem.AccountId = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].AccountId");
				dataItem.NickName = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].NickName");
				dataItem.AdminUser = _ctx.BooleanValue("QueryUserList.Result.Data["+ i +"].AdminUser");
				dataItem.Phone = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].Phone");
				dataItem.AccountName = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].AccountName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryUserListResponse.Result = result;
        
			return queryUserListResponse;
        }
    }
}

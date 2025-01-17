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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class CreateStateConfigurationResponse : AcsResponse
	{

		private string requestId;

		private CreateStateConfiguration_StateConfiguration stateConfiguration;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public CreateStateConfiguration_StateConfiguration StateConfiguration
		{
			get
			{
				return stateConfiguration;
			}
			set	
			{
				stateConfiguration = value;
			}
		}

		public class CreateStateConfiguration_StateConfiguration
		{

			private string createTime;

			private string targets;

			private string tags;

			private string stateConfigurationId;

			private string scheduleExpression;

			private string templateName;

			private string templateVersion;

			private string configureMode;

			private string scheduleType;

			private string parameters;

			private string description;

			private string resourceGroupId;

			private string templateId;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string Targets
			{
				get
				{
					return targets;
				}
				set	
				{
					targets = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public string StateConfigurationId
			{
				get
				{
					return stateConfigurationId;
				}
				set	
				{
					stateConfigurationId = value;
				}
			}

			public string ScheduleExpression
			{
				get
				{
					return scheduleExpression;
				}
				set	
				{
					scheduleExpression = value;
				}
			}

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string TemplateVersion
			{
				get
				{
					return templateVersion;
				}
				set	
				{
					templateVersion = value;
				}
			}

			public string ConfigureMode
			{
				get
				{
					return configureMode;
				}
				set	
				{
					configureMode = value;
				}
			}

			public string ScheduleType
			{
				get
				{
					return scheduleType;
				}
				set	
				{
					scheduleType = value;
				}
			}

			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}
		}
	}
}

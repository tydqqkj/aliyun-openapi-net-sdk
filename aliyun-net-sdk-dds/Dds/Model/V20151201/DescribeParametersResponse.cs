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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeParametersResponse : AcsResponse
	{

		private string engineVersion;

		private string requestId;

		private string engine;

		private List<DescribeParameters_Parameter> runningParameters;

		private List<DescribeParameters_Parameter> configParameters;

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
			}
		}

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

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public List<DescribeParameters_Parameter> RunningParameters
		{
			get
			{
				return runningParameters;
			}
			set	
			{
				runningParameters = value;
			}
		}

		public List<DescribeParameters_Parameter> ConfigParameters
		{
			get
			{
				return configParameters;
			}
			set	
			{
				configParameters = value;
			}
		}

		public class DescribeParameters_Parameter
		{

			private string checkingCode;

			private string parameterName;

			private string parameterValue;

			private string forceRestart;

			private string parameterDescription;

			private string modifiableStatus;

			public string CheckingCode
			{
				get
				{
					return checkingCode;
				}
				set	
				{
					checkingCode = value;
				}
			}

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public string ParameterValue
			{
				get
				{
					return parameterValue;
				}
				set	
				{
					parameterValue = value;
				}
			}

			public string ForceRestart
			{
				get
				{
					return forceRestart;
				}
				set	
				{
					forceRestart = value;
				}
			}

			public string ParameterDescription
			{
				get
				{
					return parameterDescription;
				}
				set	
				{
					parameterDescription = value;
				}
			}

			public string ModifiableStatus
			{
				get
				{
					return modifiableStatus;
				}
				set	
				{
					modifiableStatus = value;
				}
			}
		}
	}
}

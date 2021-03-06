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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryDeviceServiceDataResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private QueryDeviceServiceData_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QueryDeviceServiceData_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryDeviceServiceData_Data
		{

			private long? nextTime;

			private bool? nextValid;

			private List<QueryDeviceServiceData_ServiceInfo> list;

			public long? NextTime
			{
				get
				{
					return nextTime;
				}
				set	
				{
					nextTime = value;
				}
			}

			public bool? NextValid
			{
				get
				{
					return nextValid;
				}
				set	
				{
					nextValid = value;
				}
			}

			public List<QueryDeviceServiceData_ServiceInfo> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryDeviceServiceData_ServiceInfo
			{

				private string time;

				private string identifier;

				private string name;

				private string inputData;

				private string outputData;

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				public string Identifier
				{
					get
					{
						return identifier;
					}
					set	
					{
						identifier = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string InputData
				{
					get
					{
						return inputData;
					}
					set	
					{
						inputData = value;
					}
				}

				public string OutputData
				{
					get
					{
						return outputData;
					}
					set	
					{
						outputData = value;
					}
				}
			}
		}
	}
}
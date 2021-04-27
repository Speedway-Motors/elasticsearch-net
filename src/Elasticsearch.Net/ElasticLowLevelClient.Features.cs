/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elastic.Transport;
using static Elastic.Transport.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.FeaturesApi
{
	///<summary>
	/// Features APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Features"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelFeaturesNamespace : NamespacedClientProxy
	{
		internal LowLevelFeaturesNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>GET on /_features <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-features-api.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(GetFeaturesRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, "_features", null, RequestParams(requestParameters));
		///<summary>GET on /_features <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-features-api.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("features.get_features", "")]
		public Task<TResponse> GetAsync<TResponse>(GetFeaturesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, "_features", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_features/_reset <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse Reset<TResponse>(ResetFeaturesRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_features/_reset", null, RequestParams(requestParameters));
		///<summary>POST on /_features/_reset <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("features.reset_features", "")]
		public Task<TResponse> ResetAsync<TResponse>(ResetFeaturesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_features/_reset", ctx, null, RequestParams(requestParameters));
	}
}
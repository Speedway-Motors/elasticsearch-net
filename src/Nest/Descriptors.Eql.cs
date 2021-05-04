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
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.EqlApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for SearchStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
	public partial class EqlSearchStatusDescriptor : RequestDescriptorBase<EqlSearchStatusDescriptor, EqlSearchStatusRequestParameters, IEqlSearchStatusRequest>, IEqlSearchStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearchStatus;
		///<summary>/_eql/search/status/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public EqlSearchStatusDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected EqlSearchStatusDescriptor(): base()
		{
		}

		// values part of the url path
		Id IEqlSearchStatusRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	///<summary>Descriptor for Search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
	public partial class EqlSearchDescriptor<TInferDocument> : RequestDescriptorBase<EqlSearchDescriptor<TInferDocument>, EqlSearchRequestParameters, IEqlSearchRequest<TInferDocument>>, IEqlSearchRequest<TInferDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearch;
		///<summary>/{index}/_eql/search</summary>
		///<param name = "index">this parameter is required</param>
		public EqlSearchDescriptor(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>/{index}/_eql/search</summary>
		public EqlSearchDescriptor(): this(typeof(TInferDocument))
		{
		}

		// values part of the url path
		Indices IEqlSearchRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</summary>
		public EqlSearchDescriptor<TInferDocument> Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public EqlSearchDescriptor<TInferDocument> Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public EqlSearchDescriptor<TInferDocument> AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>Update the time interval in which the results (partial or final) for this search will be available</summary>
		public EqlSearchDescriptor<TInferDocument> KeepAlive(Time keepalive) => Qs("keep_alive", keepalive);
		///<summary>Control whether the response should be stored in the cluster if it completed within the provided [wait_for_completion] time (default: false)</summary>
		public EqlSearchDescriptor<TInferDocument> KeepOnCompletion(bool? keeponcompletion = true) => Qs("keep_on_completion", keeponcompletion);
		///<summary>Specify the time that the request should block waiting for the final response</summary>
		public EqlSearchDescriptor<TInferDocument> WaitForCompletionTimeout(Time waitforcompletiontimeout) => Qs("wait_for_completion_timeout", waitforcompletiontimeout);
	}
}
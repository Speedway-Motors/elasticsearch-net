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
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.AsyncSearchApi
{
	///<summary>
	/// Async Search APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.AsyncSearch"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelAsyncSearchNamespace : NamespacedClientProxy
	{
		internal LowLevelAsyncSearchNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_async_search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(string id, AsyncSearchDeleteRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_async_search/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_async_search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("async_search.delete", "id")]
		public Task<TResponse> DeleteAsync<TResponse>(string id, AsyncSearchDeleteRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_async_search/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_async_search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(string id, AsyncSearchGetRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_async_search/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_async_search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("async_search.get", "id")]
		public Task<TResponse> GetAsync<TResponse>(string id, AsyncSearchGetRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_async_search/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_async_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Submit<TResponse>(PostData body, AsyncSearchSubmitRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_async_search", body, RequestParams(requestParameters));
		///<summary>POST on /_async_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("async_search.submit", "body")]
		public Task<TResponse> SubmitAsync<TResponse>(PostData body, AsyncSearchSubmitRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_async_search", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_async_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Submit<TResponse>(string index, PostData body, AsyncSearchSubmitRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_async_search"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_async_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("async_search.submit", "index, body")]
		public Task<TResponse> SubmitAsync<TResponse>(string index, PostData body, AsyncSearchSubmitRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_async_search"), ctx, body, RequestParams(requestParameters));
	}
}
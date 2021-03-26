// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class FeaturesNamespace : NamespacedClientProxy
	{
		internal FeaturesNamespace(ElasticClient client) : base(client)
		{
		}

		public GetFeaturesResponse GetFeatures(IGetFeaturesRequest request)
		{
			return DoRequest<IGetFeaturesRequest, GetFeaturesResponse>(request, request.RequestParameters);
		}

		public Task<GetFeaturesResponse> GetFeaturesAsync(IGetFeaturesRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetFeaturesRequest, GetFeaturesResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}
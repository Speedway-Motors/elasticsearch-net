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
	public class IngestNamespace : NamespacedClientProxy
	{
		internal IngestNamespace(ElasticClient client) : base(client)
		{
		}

		public DeletePipelineResponse DeletePipeline(IDeletePipelineRequest request)
		{
			return DoRequest<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters);
		}

		public Task<DeletePipelineResponse> DeletePipelineAsync(IDeletePipelineRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetPipelineResponse GetPipeline(IGetPipelineRequest request)
		{
			return DoRequest<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters);
		}

		public Task<GetPipelineResponse> GetPipelineAsync(IGetPipelineRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GrokProcessorPatternsResponse GrokProcessorPatterns(IGrokProcessorPatternsRequest request)
		{
			return DoRequest<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters);
		}

		public Task<GrokProcessorPatternsResponse> GrokProcessorPatternsAsync(IGrokProcessorPatternsRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PutPipelineResponse PutPipeline(IPutPipelineRequest request)
		{
			return DoRequest<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters);
		}

		public Task<PutPipelineResponse> PutPipelineAsync(IPutPipelineRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters, cancellationToken);
		}

		public SimulatePipelineResponse SimulatePipeline(ISimulatePipelineRequest request)
		{
			return DoRequest<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters);
		}

		public Task<SimulatePipelineResponse> SimulatePipelineAsync(ISimulatePipelineRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}
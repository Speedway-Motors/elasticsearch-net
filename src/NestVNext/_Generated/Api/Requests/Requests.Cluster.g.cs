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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;

namespace Nest
{
    public interface ICancelTasksRequest : IRequest<CancelTasksRequestParameters>
    {
    }

    public class CancelTasksRequest : PlainRequestBase<CancelTasksRequestParameters>, ICancelTasksRequest
    {
        protected ICancelTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }

    public interface IClusterAllocationExplainRequest : IRequest<ClusterAllocationExplainRequestParameters>
    {
    }

    public class ClusterAllocationExplainRequest : PlainRequestBase<ClusterAllocationExplainRequestParameters>, IClusterAllocationExplainRequest
    {
        protected IClusterAllocationExplainRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }

    public interface IClusterGetSettingsRequest : IRequest<ClusterGetSettingsRequestParameters>
    {
    }

    public class ClusterGetSettingsRequest : PlainRequestBase<ClusterGetSettingsRequestParameters>, IClusterGetSettingsRequest
    {
        protected IClusterGetSettingsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IClusterHealthRequest : IRequest<ClusterHealthRequestParameters>
    {
    }

    public class ClusterHealthRequest : PlainRequestBase<ClusterHealthRequestParameters>, IClusterHealthRequest
    {
        protected IClusterHealthRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IClusterPendingTasksRequest : IRequest<ClusterPendingTasksRequestParameters>
    {
    }

    public class ClusterPendingTasksRequest : PlainRequestBase<ClusterPendingTasksRequestParameters>, IClusterPendingTasksRequest
    {
        protected IClusterPendingTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IClusterPutSettingsRequest : IRequest<ClusterPutSettingsRequestParameters>
    {
    }

    public class ClusterPutSettingsRequest : PlainRequestBase<ClusterPutSettingsRequestParameters>, IClusterPutSettingsRequest
    {
        protected IClusterPutSettingsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;
        protected override HttpMethod HttpMethod => HttpMethod.PUT;
        protected override bool SupportsBody => false;
    }

    public interface IClusterRerouteRequest : IRequest<ClusterRerouteRequestParameters>
    {
    }

    public class ClusterRerouteRequest : PlainRequestBase<ClusterRerouteRequestParameters>, IClusterRerouteRequest
    {
        protected IClusterRerouteRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }

    public interface IClusterStateRequest : IRequest<ClusterStateRequestParameters>
    {
    }

    public class ClusterStateRequest : PlainRequestBase<ClusterStateRequestParameters>, IClusterStateRequest
    {
        protected IClusterStateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IClusterStatsRequest : IRequest<ClusterStatsRequestParameters>
    {
    }

    public class ClusterStatsRequest : PlainRequestBase<ClusterStatsRequestParameters>, IClusterStatsRequest
    {
        protected IClusterStatsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IGetTaskRequest : IRequest<GetTaskRequestParameters>
    {
    }

    public class GetTaskRequest : PlainRequestBase<GetTaskRequestParameters>, IGetTaskRequest
    {
        protected IGetTaskRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGet;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IListTasksRequest : IRequest<ListTasksRequestParameters>
    {
    }

    public class ListTasksRequest : PlainRequestBase<ListTasksRequestParameters>, IListTasksRequest
    {
        protected IListTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface INodesHotThreadsRequest : IRequest<NodesHotThreadsRequestParameters>
    {
    }

    public class NodesHotThreadsRequest : PlainRequestBase<NodesHotThreadsRequestParameters>, INodesHotThreadsRequest
    {
        protected INodesHotThreadsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesHotThreads;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface INodesInfoRequest : IRequest<NodesInfoRequestParameters>
    {
    }

    public class NodesInfoRequest : PlainRequestBase<NodesInfoRequestParameters>, INodesInfoRequest
    {
        protected INodesInfoRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface INodesStatsRequest : IRequest<NodesStatsRequestParameters>
    {
    }

    public class NodesStatsRequest : PlainRequestBase<NodesStatsRequestParameters>, INodesStatsRequest
    {
        protected INodesStatsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesStats;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface INodesUsageRequest : IRequest<NodesUsageRequestParameters>
    {
    }

    public class NodesUsageRequest : PlainRequestBase<NodesUsageRequestParameters>, INodesUsageRequest
    {
        protected INodesUsageRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IPingRequest : IRequest<PingRequestParameters>
    {
    }

    public class PingRequest : PlainRequestBase<PingRequestParameters>, IPingRequest
    {
        protected IPingRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
        protected override HttpMethod HttpMethod => HttpMethod.HEAD;
        protected override bool SupportsBody => false;
    }

    public interface IReloadSecureSettingsRequest : IRequest<ReloadSecureSettingsRequestParameters>
    {
    }

    public class ReloadSecureSettingsRequest : PlainRequestBase<ReloadSecureSettingsRequestParameters>, IReloadSecureSettingsRequest
    {
        protected IReloadSecureSettingsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
    }

    public interface IRemoteInfoRequest : IRequest<RemoteInfoRequestParameters>
    {
    }

    public class RemoteInfoRequest : PlainRequestBase<RemoteInfoRequestParameters>, IRemoteInfoRequest
    {
        protected IRemoteInfoRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface IRootNodeInfoRequest : IRequest<RootNodeInfoRequestParameters>
    {
    }

    public class RootNodeInfoRequest : PlainRequestBase<RootNodeInfoRequestParameters>, IRootNodeInfoRequest
    {
        protected IRootNodeInfoRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceInfo;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }
}
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
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.MigrationApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.MigrationApi
{
	///<summary>
	/// Logically groups all <c>Migration</c> API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Migration"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html">http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html</a>
		/// </summary>
		public DeprecationInfoResponse DeprecationInfo(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null) => DeprecationInfo(selector.InvokeOrDefault(new DeprecationInfoDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html">http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html</a>
		/// </summary>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null, CancellationToken ct = default) => DeprecationInfoAsync(selector.InvokeOrDefault(new DeprecationInfoDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html">http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html</a>
		/// </summary>
		public DeprecationInfoResponse DeprecationInfo(IDeprecationInfoRequest request) => DoRequest<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html">http://www.elastic.co/guide/en/migration/current/migration-api-deprecation.html</a>
		/// </summary>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(IDeprecationInfoRequest request, CancellationToken ct = default) => DoRequestAsync<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.get_assistance</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html</a>
		/// </summary>
		public MigrationAssistanceResponse Assistance(Indices index = null, Func<MigrationAssistanceDescriptor, IMigrationAssistanceRequest> selector = null) => Assistance(selector.InvokeOrDefault(new MigrationAssistanceDescriptor().Index(index: index)));
		/// <summary>
		/// <c>GET</c> request to the <c>migration.get_assistance</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html</a>
		/// </summary>
		public Task<MigrationAssistanceResponse> AssistanceAsync(Indices index = null, Func<MigrationAssistanceDescriptor, IMigrationAssistanceRequest> selector = null, CancellationToken ct = default) => AssistanceAsync(selector.InvokeOrDefault(new MigrationAssistanceDescriptor().Index(index: index)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.get_assistance</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html</a>
		/// </summary>
		public MigrationAssistanceResponse Assistance(IMigrationAssistanceRequest request) => DoRequest<IMigrationAssistanceRequest, MigrationAssistanceResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.get_assistance</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-assistance.html</a>
		/// </summary>
		public Task<MigrationAssistanceResponse> AssistanceAsync(IMigrationAssistanceRequest request, CancellationToken ct = default) => DoRequestAsync<IMigrationAssistanceRequest, MigrationAssistanceResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>migration.upgrade</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html</a>
		/// </summary>
		public MigrationUpgradeResponse Upgrade(IndexName index, Func<MigrationUpgradeDescriptor, IMigrationUpgradeRequest> selector = null) => Upgrade(selector.InvokeOrDefault(new MigrationUpgradeDescriptor(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>migration.upgrade</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html</a>
		/// </summary>
		public Task<MigrationUpgradeResponse> UpgradeAsync(IndexName index, Func<MigrationUpgradeDescriptor, IMigrationUpgradeRequest> selector = null, CancellationToken ct = default) => UpgradeAsync(selector.InvokeOrDefault(new MigrationUpgradeDescriptor(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>migration.upgrade</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html</a>
		/// </summary>
		public MigrationUpgradeResponse Upgrade(IMigrationUpgradeRequest request) => DoRequest<IMigrationUpgradeRequest, MigrationUpgradeResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>migration.upgrade</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-upgrade.html</a>
		/// </summary>
		public Task<MigrationUpgradeResponse> UpgradeAsync(IMigrationUpgradeRequest request, CancellationToken ct = default) => DoRequestAsync<IMigrationUpgradeRequest, MigrationUpgradeResponse>(request, request.RequestParameters, ct);
	}
}
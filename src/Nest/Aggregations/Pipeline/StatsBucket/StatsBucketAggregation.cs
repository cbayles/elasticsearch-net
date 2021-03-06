﻿using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	[ReadAs(typeof(StatsBucketAggregation))]
	public interface IStatsBucketAggregation : IPipelineAggregation { }

	public class StatsBucketAggregation
		: PipelineAggregationBase, IStatsBucketAggregation
	{
		internal StatsBucketAggregation() { }

		public StatsBucketAggregation(string name, SingleBucketsPath bucketsPath)
			: base(name, bucketsPath) { }

		internal override void WrapInContainer(AggregationContainer c) => c.StatsBucket = this;
	}

	public class StatsBucketAggregationDescriptor
		: PipelineAggregationDescriptorBase<StatsBucketAggregationDescriptor, IStatsBucketAggregation, SingleBucketsPath>
			, IStatsBucketAggregation { }
}

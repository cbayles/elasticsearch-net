﻿using System.Collections.Generic;

namespace ApiGenerator.Configuration.Overrides.Endpoints
{
	public class GetModelSnapshotsOverrides : EndpointOverridesBase
	{
		public override IEnumerable<string> SkipQueryStringParams => new[]
		{
			"from",
			"size",
			"start",
			"end",
			"sort",
			"desc"
		};
	}
}

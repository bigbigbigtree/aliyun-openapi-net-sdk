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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSnapshotsResponseUnmarshaller
    {
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = context.HttpResponse;
			describeSnapshotsResponse.RequestId = context.StringValue("DescribeSnapshots.RequestId");
			describeSnapshotsResponse.TotalCount = context.IntegerValue("DescribeSnapshots.TotalCount");
			describeSnapshotsResponse.PageNumber = context.IntegerValue("DescribeSnapshots.PageNumber");
			describeSnapshotsResponse.PageSize = context.IntegerValue("DescribeSnapshots.PageSize");

			List<DescribeSnapshotsResponse.Snapshot> snapshots = new List<DescribeSnapshotsResponse.Snapshot>();
			for (int i = 0; i < context.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.Snapshot snapshot = new DescribeSnapshotsResponse.Snapshot();
				snapshot.SnapshotId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.SnapshotName = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.Progress = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Progress");
				snapshot.ProductCode = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].ProductCode");
				snapshot.SourceDiskId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskId");
				snapshot.SourceDiskType = context.EnumValue<DescribeSnapshotsResponse.Snapshot.SourceDiskTypeEnum>("DescribeSnapshots.Snapshots["+ i +"].SourceDiskType");
				snapshot.SourceDiskSize = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskSize");
				snapshot.Description = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Description");
				snapshot.CreationTime = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].CreationTime");
				snapshot.Status = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				snapshot.Usage = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Usage");

				List<DescribeSnapshotsResponse.Snapshot.Tag> tags = new List<DescribeSnapshotsResponse.Snapshot.Tag>();
				for (int j = 0; j < context.Length("DescribeSnapshots.Snapshots["+ i +"].Tags.Length"); j++) {
					DescribeSnapshotsResponse.Snapshot.Tag tag = new DescribeSnapshotsResponse.Snapshot.Tag();
					tag.TagKey = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagValue");

					tags.Add(tag);
				}
				snapshot.Tags = tags;

				snapshots.Add(snapshot);
			}
			describeSnapshotsResponse.Snapshots = snapshots;
        
			return describeSnapshotsResponse;
        }
    }
}
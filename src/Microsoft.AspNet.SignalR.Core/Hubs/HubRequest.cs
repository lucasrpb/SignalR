﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public class HubRequest
    {
        public string Hub { get; set; }
        public string Method { get; set; }
        public IJsonValue[] ParameterValues { get; set; }
        public IDictionary<string, object> State { get; set; }
        public string Id { get; set; }
    }
}

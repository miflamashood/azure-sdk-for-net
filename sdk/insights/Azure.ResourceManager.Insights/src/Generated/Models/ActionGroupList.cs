// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> A list of action groups. </summary>
    public partial class ActionGroupList
    {
        /// <summary> Initializes a new instance of ActionGroupList. </summary>
        internal ActionGroupList()
        {
            Value = new ChangeTrackingList<ActionGroupResource>();
        }

        /// <summary> Initializes a new instance of ActionGroupList. </summary>
        /// <param name="value"> The list of action groups. </param>
        /// <param name="nextLink"> Provides the link to retrieve the next set of elements. </param>
        internal ActionGroupList(IReadOnlyList<ActionGroupResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of action groups. </summary>
        public IReadOnlyList<ActionGroupResource> Value { get; }
        /// <summary> Provides the link to retrieve the next set of elements. </summary>
        public string NextLink { get; }
    }
}

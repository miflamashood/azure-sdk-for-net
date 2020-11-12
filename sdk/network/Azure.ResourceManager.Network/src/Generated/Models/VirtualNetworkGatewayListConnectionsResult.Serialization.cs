// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkGatewayListConnectionsResult
    {
        internal static VirtualNetworkGatewayListConnectionsResult DeserializeVirtualNetworkGatewayListConnectionsResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualNetworkGatewayConnectionListEntity>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualNetworkGatewayConnectionListEntity> array = new List<VirtualNetworkGatewayConnectionListEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkGatewayConnectionListEntity.DeserializeVirtualNetworkGatewayConnectionListEntity(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkGatewayListConnectionsResult(Optional.ToList(value), nextLink.Value);
        }
    }
}

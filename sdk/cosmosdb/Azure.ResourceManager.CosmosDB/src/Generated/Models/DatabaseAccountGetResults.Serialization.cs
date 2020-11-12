// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DatabaseAccountGetResults : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IpRules))
            {
                writer.WritePropertyName("ipRules");
                writer.WriteStartArray();
                foreach (var item in IpRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsVirtualNetworkFilterEnabled))
            {
                writer.WritePropertyName("isVirtualNetworkFilterEnabled");
                writer.WriteBooleanValue(IsVirtualNetworkFilterEnabled.Value);
            }
            if (Optional.IsDefined(EnableAutomaticFailover))
            {
                writer.WritePropertyName("enableAutomaticFailover");
                writer.WriteBooleanValue(EnableAutomaticFailover.Value);
            }
            if (Optional.IsDefined(ConsistencyPolicy))
            {
                writer.WritePropertyName("consistencyPolicy");
                writer.WriteObjectValue(ConsistencyPolicy);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities");
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableMultipleWriteLocations))
            {
                writer.WritePropertyName("enableMultipleWriteLocations");
                writer.WriteBooleanValue(EnableMultipleWriteLocations.Value);
            }
            if (Optional.IsDefined(EnableCassandraConnector))
            {
                writer.WritePropertyName("enableCassandraConnector");
                writer.WriteBooleanValue(EnableCassandraConnector.Value);
            }
            if (Optional.IsDefined(ConnectorOffer))
            {
                writer.WritePropertyName("connectorOffer");
                writer.WriteStringValue(ConnectorOffer.Value.ToString());
            }
            if (Optional.IsDefined(DisableKeyBasedMetadataWriteAccess))
            {
                writer.WritePropertyName("disableKeyBasedMetadataWriteAccess");
                writer.WriteBooleanValue(DisableKeyBasedMetadataWriteAccess.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri");
                writer.WriteStringValue(KeyVaultKeyUri);
            }
            if (Optional.IsDefined(EnableFreeTier))
            {
                writer.WritePropertyName("enableFreeTier");
                writer.WriteBooleanValue(EnableFreeTier.Value);
            }
            if (Optional.IsDefined(ApiProperties))
            {
                writer.WritePropertyName("apiProperties");
                writer.WriteObjectValue(ApiProperties);
            }
            if (Optional.IsDefined(EnableAnalyticalStorage))
            {
                writer.WritePropertyName("enableAnalyticalStorage");
                writer.WriteBooleanValue(EnableAnalyticalStorage.Value);
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WritePropertyName("cors");
                writer.WriteStartArray();
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DatabaseAccountGetResults DeserializeDatabaseAccountGetResults(JsonElement element)
        {
            Optional<DatabaseAccountKind> kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> provisioningState = default;
            Optional<string> documentEndpoint = default;
            Optional<string> databaseAccountOfferType = default;
            Optional<IList<IpAddressOrRange>> ipRules = default;
            Optional<bool> isVirtualNetworkFilterEnabled = default;
            Optional<bool> enableAutomaticFailover = default;
            Optional<ConsistencyPolicy> consistencyPolicy = default;
            Optional<IList<Capability>> capabilities = default;
            Optional<IReadOnlyList<Location>> writeLocations = default;
            Optional<IReadOnlyList<Location>> readLocations = default;
            Optional<IReadOnlyList<Location>> locations = default;
            Optional<IReadOnlyList<FailoverPolicy>> failoverPolicies = default;
            Optional<IList<VirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IReadOnlyList<PrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<bool> enableMultipleWriteLocations = default;
            Optional<bool> enableCassandraConnector = default;
            Optional<ConnectorOffer> connectorOffer = default;
            Optional<bool> disableKeyBasedMetadataWriteAccess = default;
            Optional<string> keyVaultKeyUri = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<bool> enableFreeTier = default;
            Optional<ApiProperties> apiProperties = default;
            Optional<bool> enableAnalyticalStorage = default;
            Optional<IList<CorsPolicy>> cors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new DatabaseAccountKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentEndpoint"))
                        {
                            documentEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseAccountOfferType"))
                        {
                            databaseAccountOfferType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IpAddressOrRange> array = new List<IpAddressOrRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpAddressOrRange.DeserializeIpAddressOrRange(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("isVirtualNetworkFilterEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isVirtualNetworkFilterEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticFailover"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAutomaticFailover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("consistencyPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            consistencyPolicy = ConsistencyPolicy.DeserializeConsistencyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("capabilities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Capability> array = new List<Capability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Capability.DeserializeCapability(item));
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("writeLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Location> array = new List<Location>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.Location.DeserializeLocation(item));
                            }
                            writeLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("readLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Location> array = new List<Location>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.Location.DeserializeLocation(item));
                            }
                            readLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("locations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Location> array = new List<Location>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.Location.DeserializeLocation(item));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("failoverPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FailoverPolicy> array = new List<FailoverPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FailoverPolicy.DeserializeFailoverPolicy(item));
                            }
                            failoverPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("enableMultipleWriteLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableMultipleWriteLocations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableCassandraConnector"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableCassandraConnector = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("connectorOffer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectorOffer = new ConnectorOffer(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableKeyBasedMetadataWriteAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableKeyBasedMetadataWriteAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultKeyUri"))
                        {
                            keyVaultKeyUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableFreeTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableFreeTier = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            apiProperties = ApiProperties.DeserializeApiProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableAnalyticalStorage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAnalyticalStorage = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CorsPolicy> array = new List<CorsPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CorsPolicy.DeserializeCorsPolicy(item));
                            }
                            cors = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DatabaseAccountGetResults(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), Optional.ToNullable(kind), provisioningState.Value, documentEndpoint.Value, databaseAccountOfferType.Value, Optional.ToList(ipRules), Optional.ToNullable(isVirtualNetworkFilterEnabled), Optional.ToNullable(enableAutomaticFailover), consistencyPolicy.Value, Optional.ToList(capabilities), Optional.ToList(writeLocations), Optional.ToList(readLocations), Optional.ToList(locations), Optional.ToList(failoverPolicies), Optional.ToList(virtualNetworkRules), Optional.ToList(privateEndpointConnections), Optional.ToNullable(enableMultipleWriteLocations), Optional.ToNullable(enableCassandraConnector), Optional.ToNullable(connectorOffer), Optional.ToNullable(disableKeyBasedMetadataWriteAccess), keyVaultKeyUri.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(enableFreeTier), apiProperties.Value, Optional.ToNullable(enableAnalyticalStorage), Optional.ToList(cors));
        }
    }
}

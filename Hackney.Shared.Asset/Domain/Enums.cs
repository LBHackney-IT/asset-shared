using System.Text.Json.Serialization;

namespace Hackney.Shared.Asset.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AssetType
    {
        Block,
        Concierge,
        Dwelling,
        LettableNonDwelling,
        MediumRiseBlock,
        NA,
        TravellerSite
    }
}
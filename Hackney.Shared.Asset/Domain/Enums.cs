using System.Runtime.Serialization;
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
        TravellerSite,
        AdministrativeBuilding,
        BoilerHouse,
        BoosterPump,
        CleanersFacilities,
        CombinedHeatAndPowerUnit,
        CommunityHall,
        Estate,
        HighRiseBlock,
        Lift,
        LowRiseBlock,
        NBD,
        OutBuilding,
        TerracedBlock,
        WalkUpBlock,
        StudioFlat,
        Flat,
        Room,
        House,
        SelfContainedBedsit,
        Maisonette,
        [EnumMember(Value = "New Build")]
        NewBuild
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Frequency
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}

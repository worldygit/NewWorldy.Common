using NewWorldy.Common.WorldOfWarcraft.Enumerations;

namespace NewWorldy.Common.WorldOfWarcraft.Units;

public sealed class Player : Unit
{
    public Class Class { get; internal set; } = Class.Unknown;

    public Specialization Specialization { get; internal set; } = Specialization.Unknown;

    public Race Race { get; internal set; } = Race.Unknown;
}
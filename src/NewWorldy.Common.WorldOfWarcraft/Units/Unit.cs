namespace NewWorldy.Common.WorldOfWarcraft.Units;

public class Unit
{
    public int HealthPercentage { get; internal set; }

    public bool IsDead => HealthPercentage <= 0;
}
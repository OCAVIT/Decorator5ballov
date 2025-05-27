public class ClassicHotdog : Hotdog
{
    private const int Cost = 210;
    private const int Weight = 150;

    public ClassicHotdog() : base("Хот-дог классический") { }

    public override int GetCost() => Cost;
    public override int GetWeight() => Weight;
}

public class CheeseHotdog : Hotdog
{
    private const int Cost = 250;
    private const int Weight = 160;

    public CheeseHotdog() : base("Хот-дог с сыром") { }

    public override int GetCost() => Cost;
    public override int GetWeight() => Weight;
}

public class SpicyHotdog : Hotdog
{
    private const int Cost = 230;
    private const int Weight = 155;

    public SpicyHotdog() : base("Хот-дог острый") { }

    public override int GetCost() => Cost;
    public override int GetWeight() => Weight;
}
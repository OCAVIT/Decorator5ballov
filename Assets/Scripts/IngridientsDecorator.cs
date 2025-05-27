public class PicklesDecorator : HotdogDecorator
{
    private const int PicklesCost = 50;
    private const int PicklesWeight = 20;

    public PicklesDecorator(Hotdog baseHotdog)
        : base(baseHotdog, $"{baseHotdog.GetName()} с маринованными огурцами") { }

    public override int GetCost() => _baseHotdog.GetCost() + PicklesCost;
    public override int GetWeight() => _baseHotdog.GetWeight() + PicklesWeight;
}

public class SweetOnionDecorator : HotdogDecorator
{
    private const int OnionCost = 30;
    private const int OnionWeight = 10;

    public SweetOnionDecorator(Hotdog baseHotdog)
        : base(baseHotdog, $"{baseHotdog.GetName()} с сладким луком") { }

    public override int GetCost() => _baseHotdog.GetCost() + OnionCost;
    public override int GetWeight() => _baseHotdog.GetWeight() + OnionWeight;
}
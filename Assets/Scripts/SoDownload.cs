public class SOHotdog : Hotdog
{
    private readonly HotdogConfig _config;

    public SOHotdog(HotdogConfig config) : base(config.hotdogName)
    {
        _config = config;
    }

    public override int GetCost() => _config.cost;
    public override int GetWeight() => _config.weight;
}

public class SOHotdogDecorator : HotdogDecorator
{
    private readonly IngredientConfig _ingredientConfig;

    public SOHotdogDecorator(Hotdog baseHotdog, IngredientConfig ingredientConfig)
        : base(baseHotdog, $"{baseHotdog.GetName()} ñ {ingredientConfig.ingredientName}")
    {
        _ingredientConfig = ingredientConfig;
    }

    public override int GetCost() => _baseHotdog.GetCost() + _ingredientConfig.cost;
    public override int GetWeight() => _baseHotdog.GetWeight() + _ingredientConfig.weight;
}
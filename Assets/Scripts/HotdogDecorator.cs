public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog _baseHotdog;

    protected HotdogDecorator(Hotdog baseHotdog, string name) : base(name)
    {
        _baseHotdog = baseHotdog;
    }

    public override string GetName() => _name;
    public override abstract int GetCost();
    public override abstract int GetWeight();
}
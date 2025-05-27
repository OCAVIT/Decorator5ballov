using UnityEngine;

public class HotdogDebugComponent : MonoBehaviour
{
    [Header("Base Hotdogs")]
    public HotdogConfig classicConfig;
    public HotdogConfig cheeseConfig;
    public HotdogConfig spicyConfig;

    [Header("Ingredients")]
    public IngredientConfig picklesConfig;
    public IngredientConfig sweetOnionConfig;

    private void Start()
    {
        DebugHotdog(new SOHotdog(classicConfig));
        DebugHotdog(new SOHotdog(cheeseConfig));
        DebugHotdog(new SOHotdog(spicyConfig));
    }

    private void DebugHotdog(Hotdog baseHotdog)
    {
        Debug.Log($"{baseHotdog.GetName()} ({baseHotdog.GetWeight()}�) � {baseHotdog.GetCost()}�.\n�������������� ����������:\n" +
            $"{new SOHotdogDecorator(baseHotdog, picklesConfig).GetName()} ({new SOHotdogDecorator(baseHotdog, picklesConfig).GetWeight()}�) � {new SOHotdogDecorator(baseHotdog, picklesConfig).GetCost()}�.\n" +
            $"{new SOHotdogDecorator(baseHotdog, sweetOnionConfig).GetName()} ({new SOHotdogDecorator(baseHotdog, sweetOnionConfig).GetWeight()}�) � {new SOHotdogDecorator(baseHotdog, sweetOnionConfig).GetCost()}�.");
    }
}
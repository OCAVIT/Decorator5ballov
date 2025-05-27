using UnityEngine;

[CreateAssetMenu(fileName = "HotdogConfig", menuName = "Hotdog/Config", order = 1)]
public class HotdogConfig : ScriptableObject
{
    public string hotdogName;
    public int cost;
    public int weight;
}
using UnityEngine;

[CreateAssetMenu(fileName = "IngredientConfig", menuName = "Hotdog/IngredientConfig", order = 2)]
public class IngredientConfig : ScriptableObject
{
    public string ingredientName;
    public int cost;
    public int weight;
}
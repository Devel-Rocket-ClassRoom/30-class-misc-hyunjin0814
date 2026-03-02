using System;
public partial class Recipe
{
    private string[] ingredients;
    private int count;

    public string Name { get; }
    public int Servings { get; }
    public int Length { get; }

    public Recipe(string name, int servings, int maxIngredient)
    {
        count = 0;
        Name = name;
        Servings = servings;
        Length = maxIngredient;
        ingredients = new string[Length];
    }
}
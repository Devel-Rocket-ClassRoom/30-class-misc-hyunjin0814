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

    public void AddIngredient(string ingredient)
    {
        if (count > Length)
        {
            Console.WriteLine("배열이 가득 찼습니다.");
        }
        else
        {
            ingredients[count++] = ingredient;
        }
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i,2}. {ingredients[i]}");
        }
    }

    public bool HasIngredient(string ingredient)
    {
        bool hasIngredient;

        for (int i = 0; i < count; i++)
        {
            
        }
    }
}
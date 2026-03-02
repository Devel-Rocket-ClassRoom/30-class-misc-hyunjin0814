using System;

public partial class Recipe
{
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
            Console.WriteLine($"{i + 1, 2}. {ingredients[i]}");
        }
        Console.WriteLine();
    }

    public bool HasIngredient(string ingredient)
    {
        bool hasIngredient = false;

        for (int i = 0; i < count; i++)
        {
            if (ingredient == ingredients[i])
            {
                hasIngredient = true;
            }
        }

        return hasIngredient;
    }
}
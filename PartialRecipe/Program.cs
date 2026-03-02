using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Recipe bibimbab = new Recipe("비빔밥", 2, 5);
bibimbab.AddIngredient("밥");
bibimbab.AddIngredient("고추장");
bibimbab.AddIngredient("계란");
bibimbab.AddIngredient("시금치");
bibimbab.AddIngredient("당근");

bibimbab.PrintRecipe();
Console.WriteLine($"계란 포함: {bibimbab.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함: {bibimbab.HasIngredient("소고기")}");
Console.WriteLine();

Recipe sandwich = new Recipe("샌드위치", 1, 3);
sandwich.AddIngredient("빵");
sandwich.AddIngredient("햄");
sandwich.AddIngredient("치즈");

sandwich.PrintRecipe();

using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Money money1 = new Money(100, 50);
Money money2 = money1.Add(50, 30);
Money money3 = money2.Subtract(70, 60);

Money money4 = new Money(100, 50)
    .Add(40, 20)
    .Subtract(20, 40);

Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"지갑: {money1}");
Console.WriteLine();

Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {money2}");
Console.WriteLine($"원본 지갑: {money1}");
Console.WriteLine();

Console.WriteLine("=== 화폐 차감 ===");
Console.WriteLine($"차감 후: {money3}");
Console.WriteLine($"원본 지갑: {money1}");
Console.WriteLine();

Console.WriteLine("=== 메서드 체이닝 ===");
Console.WriteLine($"결과: {money4}");
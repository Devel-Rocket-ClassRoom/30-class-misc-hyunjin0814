using System;

// README.md를 읽고 아래에 코드를 작성하세요.
QueryBuilder qb1 = new QueryBuilder();
QueryBuilder qb2 = new QueryBuilder();
QueryBuilder qb3 = new QueryBuilder();

string basic = qb1.Select("*").From("Users").Build();
string condition = qb2.Select("Name, Age").From("Users").Where("Age > 18").Build();
string array = qb3.Select("*")
    .From("Products")
    .Where("Price > 1000")
    .OrderBy("Price")
    .Build();

Console.WriteLine("=== 기본 쿼리 ===");
Console.WriteLine(basic);
Console.WriteLine();

Console.WriteLine("=== 조건 쿼리 ===");
Console.WriteLine(condition);
Console.WriteLine();

Console.WriteLine("=== 정렬 쿼리 ===");
Console.WriteLine(array);
Console.WriteLine();
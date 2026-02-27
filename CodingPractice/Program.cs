using System;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.
Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();

Hello hello = new Hello();
hello.Hi();
hello.Bye();

Console.WriteLine($"덧셈 :{Calculator.Add(10, 20)}");
Console.WriteLine($"뺄셈 :{Calculator.Add(30, 10)}");
Console.WriteLine($"곱셈 :{Calculator.Add(10, 3)}");

string text = "  hello world  ";
Console.WriteLine(StringHelper.CleanAndUpper(text));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));

Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
Console.WriteLine($"최솟값: {Math.Min(10, 20)}");

StringBuilder sb =  new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
string result1 = sb.ToString();

string result2 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

Console.WriteLine(result1);
Console.WriteLine(result2);

string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요")
    .Build();

Console.WriteLine(message);

Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

Console.WriteLine(point);

Console.WriteLine(text.Trim().ToLower().Replace(" ", "_"));

MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20;
Console.WriteLine($"반지름: {circle.Radius}");

ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.Radius}");

ImmutableCircle circle2 = circle1.WithRadius(20); 
Console.WriteLine($"새 원 반지름: {circle2.Radius}");
Console.WriteLine($"원본 반지름: {circle1.Radius}");

Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUp();
Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");

string original = "Hello";
string modified = original.ToUpper();

Console.WriteLine($"원본: {original}");  
Console.WriteLine($"수정본: {modified}");

Character hero = new Character("용사", 100, 1);
Console.WriteLine($"{hero.Name} - 레벨: {hero.Level}, 체력: {hero.Health}");
hero.TakeDamage(30);
hero.Heal(10);

int damage = GameHelper.CalculateDamage(10, 5);
bool alive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);

Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {alive}");
Console.WriteLine($"체력 상태: {status}");

Vector2D vector = new Vector2D(1, 1)
    .Add(2, 3)
    .Multiply(2)
    .Add(-1, -2);

Console.WriteLine($"결과 벡터: {vector.ToString()}");
class Vector2D
{
    private readonly double X;
    private readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x; Y = y; 
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }
    public Vector2D Multiply(double amount)
    {
        return new Vector2D(X * amount, Y * amount);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

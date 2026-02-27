class Point
{
    private readonly int X;
    private readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point MoveBy(int dx, int dy) => new Point(X + dx, Y + dy);

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
class Money
{
    public int Gold { get; }
    public int Silver { get; }

    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public Money Add(int gold, int silver) => new Money(Gold + gold, Silver +silver);
    
    public Money Subtract(int gold, int silver)
    {
        int newGold;
        int newSilver;

        if (Gold - gold < 0)
        {
            newGold = 0;    
        }
        else
        {
            newGold = Gold - gold;
        }
        if (Silver - silver < 0)
        {
            newSilver = 0;
        }
        else
        {
            newSilver = Silver - silver;
        }

        return new Money(newGold, newSilver);
    }

    public override string ToString()
    {
        return $"{Gold}골드 {Silver}실버";
    }
}
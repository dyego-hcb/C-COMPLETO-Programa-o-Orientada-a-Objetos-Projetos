class Calculator
{
    public static void TripleBad(int x)
    {
        x = x * 3;
    }

    public static void TripleRef(ref int x)
    {
        x = x * 3;
    }

    public static void TripleOut(int origin, out int result)
    {
        result = origin * 3;
    }
}
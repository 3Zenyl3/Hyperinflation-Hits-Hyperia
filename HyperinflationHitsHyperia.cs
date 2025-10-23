public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            long res = checked(@base * multiplier);
            return res.ToString();
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {

        float res = checked(@base * multiplier);
        if (float.IsInfinity(res))
        {
            return "*** Too Big ***";
        }
        else
        {
            return res.ToString();
        }

            
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            decimal res = salaryBase*multiplier;
            return res.ToString();
        }
        catch(OverflowException)
        {
            return "*** Much Too Big ***";
        }
        
    }
}

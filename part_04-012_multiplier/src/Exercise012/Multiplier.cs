public class Multiplier
{
    public int multiplier;
    public Multiplier(int number)
    {
        this.multiplier = number;
    }

    public int Multiply(int number)
    {
        int result = this.multiplier * number;
        this.multiplier = result;
        return result;
    }
}
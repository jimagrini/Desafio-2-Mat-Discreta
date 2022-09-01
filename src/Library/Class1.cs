namespace Library;
public class Challenge
{
    public void Calculator(int edad)
    {
        int Amount_Ahorro=0;
        int Amount=0;
        for(int Age=10; Age <=edad; Age++)
        {
            Amount+= Age+Amount_Ahorro;
            Amount_Ahorro+=Age;

        }
        Console.WriteLine($"Carlos desde los 10 años hasta los {edad}, logro ahorrar ${Amount}");
    }

}

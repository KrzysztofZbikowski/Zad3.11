class Zad
{
    static void Main(string[] args)
    {
        int suma=0, zm=1, licz=0;
        do
        {
            suma = suma + zm;
            zm++;
            licz++;
        } while (suma <= 100);
        Console.WriteLine("Aby suma kolejnych liczb całkowitych przekroczyła wartość 100 należy dodać {0} kolejnych liczb", licz);
        Console.ReadKey();
    }
}
{
    static void Main(string[] args)
    {
        int decimalNumber = 46;
        Console.WriteLine($"Десятичное число: {decimalNumber}");

        string binaryNumber = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Двоичное число: {binaryNumber}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }
        return binaryNumber;
    }
}


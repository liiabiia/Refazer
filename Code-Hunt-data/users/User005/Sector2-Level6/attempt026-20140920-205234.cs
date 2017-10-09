

using System;
public class Program {

    public static string Puzzle(int n) {
        return IntToBinaryString(n);
    }
	
	public string IntToBinaryString(int number)
{
    const int mask = 1;
    var binary = string.Empty;
    while(number > 0)
    {
        // Logical AND the number and prepend it to the result string
        binary = (number & 1) + binary;
        number = number >> 1;
    }

    return binary;
}
	
	
}



public class Program {
    public static int Puzzle(char[] s)
	{ 
		int count=0;
		for (i = 0;s[i] != '\0';i++)
    {
        if (s[i] == ' ')
            count++;    
    }return count;
	}
}
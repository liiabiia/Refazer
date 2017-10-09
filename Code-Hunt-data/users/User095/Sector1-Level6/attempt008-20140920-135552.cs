


public class Program {

    public static int Puzzle(string s) {
        

char[] delimiters = new char[] {' ', '\r', '\n' };
return s.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;  


    }
}

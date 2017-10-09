
public class Program {

    public static int Puzzle(string s) {
        char[] texto = new char[500];
        int a = 1;
        for (int i = 0; i <= s.Length; i++) {
            if (texto[i] == ' ') a++;
        }
        return a;
    }
}

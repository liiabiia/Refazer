

public class Program {

    public static string Puzzle(string s) {
        char t;
        char[] st = System.Linq.Enumerable.ToArray<char>(s);
        for (int i = 1; i < s.Length / 2; i++) {
            t = st[i];
            st[i] = st[s.Length - i - 1];
            st[s.Length - i - 1] = t;
        }
        return CodeHunt.JavaExtras.ArrayToString<char>(st);
    }
}


// Extra C# methods needed by the converted Java code

namespace CodeHunt {

public class JavaExtras {
}

}

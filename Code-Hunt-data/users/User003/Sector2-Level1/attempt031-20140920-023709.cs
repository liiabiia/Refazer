


public class Program {

    public static int Puzzle(int[] a) {
        int sum = 0;
        for (int i = 0; i < a.Length; i++) if(a[i]==87)a[i]+=1;sum +=a[i] / a.Length;
        return (sum);
    }
}

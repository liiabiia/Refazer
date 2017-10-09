

public class Program {
  public static int Puzzle(int n) {
    int[] tab = new int[n+1];
	tab[0] = 0;
	tab[1] = 1;
	tab[2] = 2;
	for(int i =3;i<=n;i++)
		tab[i]=tab[i-1]+tab[i-2];
	return tab[n];
  }
}
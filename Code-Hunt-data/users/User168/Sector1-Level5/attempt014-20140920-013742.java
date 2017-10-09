

public class Program {
    public static int Puzzle(int[] a) {
	  int cont1=0, cont2=0;
	  int x =0;
	  for(int i:a)
	  {
		x++;
	  }
	  if(cont1<cont2)x=1;
	  else x=0;
	  return x;
    }
}


public class Program {
    public static int Puzzle(int[] a) {
      int cont1=0, cont2=0;
	  int x =0;
	  for(int i:a)
	  {
		x=i;
		if(x==0)
			cont1++;
		if(x==1)
			cont2++;
	  }
	  if(cont1>cont2)return 0;
	  else return 1;
	  return x;
    }
}
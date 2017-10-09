

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int atual = -1;
	  int menor = 0;
	  while (atual < k){
		  atual++;
		  for(int i = menor+1; i < a.length; i++){
			  if(a[i] < a[menor]){
				  menor = i;
			  }
		  }
		  int aux = a[atual];
		  a[atual] = a[menor];
		  a[menor] = aux;
	  }
	  return a[k];
  }
}
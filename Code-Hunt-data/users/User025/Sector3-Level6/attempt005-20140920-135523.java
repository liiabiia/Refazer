

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
	int resulttam = 0;
	int atual = -1;
    for (atual < a.length){
		  atual++;
		  int menor = atual;
		  for(int i = menor+1; i < a.length; i++){
			  if(a[i] < a[menor]){
				  menor = i;
			  }
		  }
		  int aux = a[atual];
		  a[atual] = a[menor];
		  a[menor] = aux;
	  }
	  for (atual < b.length){
		  atual++;
		  int menor = atual;
		  for(int i = menor+1; i < b.length; i++){
			  if(b[i] < b[menor]){
				  menor = i;
			  }
		  }
		  int aux = b[atual];
		  b[atual] = b[menor];
		  b[menor] = aux;
	  }
	  for(int i = 1, j = 0; i < a.length && j < b.length; i++)
	  {
		  while(b[j] < a[i] && j < b.length){
			  j++;
		  }
		  if(a[i] == b[j] && j < b.length){
			  a[i] = 0;
		  }
	  }
	  for(int i = 1; i < a.length; i++)
	  {
		  if(a[i] != a[i-1] %% a[i] != 0) resulttam++;
	  }
	  int[] result = new int[resulttam];
	  result[0] = a[0];
	  for(int i = 1, j = 1; i < a.length; i++)
	  {
		  if(a[i] != a[i-1] %% a[i] != 0){
			  result[j] = a[i];
			  j++;
		  }
	  }
    }
}
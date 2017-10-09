using System;

public class Objeto{
	int valor;
	Objeto ant;
}
public class Program {
  public static int Puzzle(int[] a, int k) {
	  Objeto objetok = new Objeto();
	  objetok.valor = a[0];
	  int atual = 1;
	  //até k
	  while(atual <= k){
		  if(a[atual] < objetok.valor){
			  Objeto novo = new Objeto();
			  novo.valor = a[atual];
			  //busca td p tras
			  Objeto aux = objetok;
			  while(aux.ant && (aux.ant).valor > novo.valor){
			  		aux = aux.ant;
			  }
			  novo.ant = aux.ant;
			  aux.ant = novo;
		  }
		  else{
			  Objeto novo = new Objeto();
			  novo.valor = a[atual];
			  novo.ant = objetok;
			  objetok = novo;
		  }
		  k++;
	  }
	  //k em diante
	  while(atual < a.length){
		  if(a[atual] < objetok.valor){
			  //busca td p tras
			  Objeto aux = objetok;
			  while(aux.ant && (aux.ant).valor > novo.valor){
			  		aux = aux.ant;
			  }
			  novo.ant = aux.ant;
			  aux.ant = novo;
			  objetok = objetok.ant;
		  }
	  }
    return objetok.valor;
  }
}
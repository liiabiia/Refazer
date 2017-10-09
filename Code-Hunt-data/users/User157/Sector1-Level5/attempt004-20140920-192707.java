

public class Program {
    public static int Puzzle(int[] a) {
	  int maior=0;
	  for(int i : a){
		  if(i>maior)
		  	maior=i;
	  }	
      return maior;
    }
}
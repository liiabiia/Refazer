

public class Program {
  public static int Puzzle(int a, int b) {
	  int c;
	  if(a < b){
		  c=a;
	  }else if(a > b){
		  c=b;
	  }else{
		  return a;
	  }
	  
	  for(int i=2;i<c;i++){
		  if(a%c==0 && b%c==0){
			  return a*b/c;
		  }
	  }
	  
	  return a*b;
  }
}
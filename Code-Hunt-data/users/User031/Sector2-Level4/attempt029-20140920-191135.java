

public class Program {
  public static int Puzzle(int a, int b) {
	  int c;
	  int highest=1;
	  if(a < b){
		  c=a;
	  }else if(a > b){
		  c=b;
	  }else{
		  return a;
	  }
	  
	  for(int i=2;i<c;i++){
		  if(a%i==0 && b%i==0){
			  highest=i;
		  }
	  }
	  
	  return a*b/highest;
  }
}
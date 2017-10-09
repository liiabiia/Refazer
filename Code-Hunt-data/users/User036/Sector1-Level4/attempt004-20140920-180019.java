

public class Program {
  public static Boolean Puzzle(int x, int y) {
    return isprime(y);
  }
  
  public int isprime(int n){
	  for(int i=2;i<n;i++){
		  if(n%i==0)
		  	return false;
	  }
	  return true;
  }
}

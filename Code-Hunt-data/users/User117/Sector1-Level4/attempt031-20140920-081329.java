

public class Program {
	
	 public boolean isPrimeNumber(int number){
         
        for(int i=2; i<=number/2; i++){
            if(number % i == 0){
                return false;
            }
        }
        return true;
    }
  public static Boolean Puzzle(int x, int y) {
	 if(isPrimeNumber(x)&&isPrimeNumber(y)){return false;}else return true;
	
	
  }
}
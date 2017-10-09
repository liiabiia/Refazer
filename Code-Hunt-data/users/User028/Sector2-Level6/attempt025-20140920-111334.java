

public class Program {
  public static String Puzzle(int n) {
   StringBuffer temp= new StringBuffer();
	    int r;
        do{
            r=n%2;
            n=n/2;         
            temp.append(r);                       
        }while (q!=0);
        return temp.reverse().toString();
  }
}


public class Program {
  public static String Puzzle(int n) {
    StringBuffer temp= new StringBuffer();
	    int q,r;
             do{
            q=n/2;
            r=n%2;
            n=q;         
            temp.append(r).reverse();                       
        }while (q!=0);
		return temp.toString();
  }
}
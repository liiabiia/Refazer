public class Program {
  public static int Puzzle(String s) {
	 int cont=0;
	 StringTokenizer st = new StringTokenizer(s);
     while (st.hasMoreTokens()) {
		 cont++;
     }
	 
	 return cont;

  }
}
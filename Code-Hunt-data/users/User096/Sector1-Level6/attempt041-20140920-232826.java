public class Program {
  public static int Puzzle(String s) {

	String s2 = s;  
        int imenor=0;  
        int imaior=0;  
          
        String quebra[50] = s2.split(" ");  
          
        for ( int i = 0 ; i < quebra.length ; i++ ) {  
            if ( quebra<i>.length() < quebra[imenor].length() ) {  
                imenor = i;  
            }  
            if ( quebra<i>.length() > quebra[imaior].length() ) {  
                imaior = i;  
            }  
              
        }  
	return quebra.length;
  }
}
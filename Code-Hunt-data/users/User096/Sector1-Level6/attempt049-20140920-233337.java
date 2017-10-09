public class Program {
  public static int Puzzle(String s) {

	int contadorPalavraChave = 0;  
        int total = 0;

        String frase = s;
        sc.useDelimiter("[,;:.!? ]");  
 
        while (sc.hasNext()) {  
            String proximaPalavra = sc.next();  
            if (proximaPalavra.length() > 0) {
                total++;
                if(proximaPalavra.equalsIgnoreCase(palavraChave)){
                    contadorPalavraChave++;
                }
            }  
        } 
	
	return total;

  }
}


public class Program {
  public static int Puzzle(String s) { 
	 String stg = "" + s;
        int quantidade = 0;
        String[] palavras = stg.split(" ");
        for (int i=0; i<stg.length();i++){
        if (palavras[i].equals("")) {
             quantidade = 0;   
        } else{
             quantidade = i+1; 
        }
        }
		return quantidade;
		}}
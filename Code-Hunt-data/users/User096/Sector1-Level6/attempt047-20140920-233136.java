public class Program {
  public static int Puzzle(String s) {

	 int totalWords = 0;

for (int i = 0; i < s.length ; i ++){

totalWords +=s.split( " [^ a -zA- Z0-9 ] +").length;

} 
return totalWords;
  }
}
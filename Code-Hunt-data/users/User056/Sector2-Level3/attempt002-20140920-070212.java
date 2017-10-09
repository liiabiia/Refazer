

public class Program {
  public static String Puzzle(String s) {

String s1= new StringBuffer(s).reverse().toString();
char c[]= s1.toCharArray();
char k = c[0];
c[0]=c[c.length-1];
c[c.length-1]=k;
String s2=String.valueOf(c);
return s2;    
  }
}
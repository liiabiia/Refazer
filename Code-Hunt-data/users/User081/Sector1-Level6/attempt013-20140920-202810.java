import java.util.*;

public class Program {
  public static int Puzzle(String s){
  Scanner inp=new Scanner(System.in);
  String st=inp.nextLine();
  int c=0;
  StringTokenizer stt=new StringTokenizer(st," ");
  while(stt.hasMoreTokens())
  {
	  String t=stt.nextToken();
	  c++;
  }
  return c;
  }
}
import java.lang.*;

public class Program {
  public static int Puzzle(String s){
  int cont=0;
  for(int i=0;i<=s.length;i++)
  {if(s[i]=="")
  {cont+=1;}
  }
    return cont;
  }
}
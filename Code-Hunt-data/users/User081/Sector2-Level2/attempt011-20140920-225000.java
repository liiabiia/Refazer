

public class Program {
  public static int Puzzle(String s) {
	  
    int index=0,cd=0,d=0;
 
  while(index<s.length())
  {  char c=s.charAt(index++);
  if(c=='(')
  cd++;
  else if(c==')')
  d++;
  }
  if(cd>0&&d>0){
  if(cd>d)
  return cd-d;
  else 
  return d-cd;
  }
  return 0;
}
}
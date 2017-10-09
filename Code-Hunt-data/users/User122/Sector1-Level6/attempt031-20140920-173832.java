

public class Program {
	  public static int Puzzle(String s) { 
int g =s.length();; int ii=0;
	  for(int i=0; i<g; i++){
  char c = s.charAt(i);
  if(c==' ') // fill in the ascii oct values
    ++ii;
}

String[] words= s.trim().split("\\s+");
if(ii == g){   int x = words.length; } else int x=0;
  return x;
  }
}
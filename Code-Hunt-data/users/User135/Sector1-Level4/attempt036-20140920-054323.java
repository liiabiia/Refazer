

public class Program {
  public static Boolean Puzzle(int x, int y) {
int has;
if(x>y)    
has = x -y;
else
has = y - x;

if (has%2)
return true;
else
return false;
 }
}
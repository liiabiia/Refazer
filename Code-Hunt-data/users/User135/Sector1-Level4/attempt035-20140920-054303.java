

public class Program {
  public static Boolean Puzzle(int x, int y) {
if(x>y)    
int has = x -y;
else
int has = y - x;

if (has%2)
return true;
else
return false;
 }
}


public class Program {
    public static int Puzzle(String s){
	//last word must be count
	int count=1;
                 for(int i=0;i<s.length();i++)
                 {
                   ch=s.charAt(i);
                   if(ch==' ')
                   {
                     count++;
                   }
                 }         
return count;
  }
}
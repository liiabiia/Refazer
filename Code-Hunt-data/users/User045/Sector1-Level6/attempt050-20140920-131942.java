

public class Program {
  public static int Puzzle(String s) {
    int count=0,blank=0;String s1=" ";s1=s1.concat(s);s1=s1.concat(s1);
    for(int i=0;i<s.length();i++){
      if((i>0 && s1.charAt(i)==' ' && s1.charAt(i-1)!=' ') || (i==0 && s1.charAt(i)==' ' && s1.charAt(i+1)!=' ')) count++;
	  if(s1.charAt(i)=' ') blank++;
    }
	if(s.charAt(0)=' ' && blank!=s.length()) count++;
	return count;
  }
}
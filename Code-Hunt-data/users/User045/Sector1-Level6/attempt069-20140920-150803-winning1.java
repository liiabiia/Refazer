

public class Program {
  public static int Puzzle(String s) {
    /*int count=0,blank=0;String s1=" ";s1=s1.concat(s);
    for(int i=0;i<s.length();i++){
      if((i>0 && s1.charAt(i)==' ' && s1.charAt(i-1)!=' ') || (i==0 && s1.charAt(i)==' ' && s1.charAt(i+1)!=' ')) count++;
    }
	if(s1.charAt(0)==' ' && (s1.charAt(1)!=' ' ||s1.charAt(2)!=' ')) count++;
	return count;*/
	int count =0;String s1=" ";s1=s1.concat(s);
	for (int i=0;i<s1.length();i++){
		if(i>0 && s1.charAt(i)!=' ' && s1.charAt(i-1)==' ') count++;
	}
	return count;
  }
}


public class Program {
  public static int Puzzle(String s) {
    	String[] list=s.split(" ");
		int cnt=0;
		for(int i=0;i<list.length;i++)
		{
			if(list[i].length()<=1 && list[i].equals(""));
			else
				cnt++;
		}
	return cnt;
  }
}
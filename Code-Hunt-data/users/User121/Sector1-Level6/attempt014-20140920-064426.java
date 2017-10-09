
public class Program {
  public static int Puzzle(String s) {
String[] arr = s.split("\\s+");
int sum=0;
for(int i=0;i<arr.length;i++)
{
	if(arr[i].replaceAll("\\s+","").split("\\s+").length ==1)
		sum++;
}
	
	return sum;
  }
}


public class Program {
  public static int Puzzle(String s) {
int i,count=0,j=0,start=0,end=0,max=0;
for(i=0;i<s.length();i++)
{if(s.substring(i,i+1)=="(")
{count++;start++;j++;}

if(s.substring(i,i+1)==")")
{count--;end++;}
if(count==0 && (start-end)==0)
{if(max<j)
max=j;
start=0;end=0;j=0;}
if(count<0)
break;
}
  if(count==0)  return max;
else return 0;
  }
}
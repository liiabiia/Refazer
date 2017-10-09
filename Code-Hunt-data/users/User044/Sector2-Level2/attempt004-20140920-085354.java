

public class Program {
  public static int Puzzle(String s) {
int i,count=0,j=0,start=0,end=0;
for(i=0;i<s.length();i++)
{if(s.substring(i,i+1)=="(")
{count++;start++;j++;}

if(s.substring(i,i+1)==")")
{count--;end++;}
if(s.substring(i,i+1)=="(" && count==0 && (start-end)==0)
{start=0;end=0;}
if(count<0)
break;
}
  if(count==0)  return j;
else return 0;
  }
}
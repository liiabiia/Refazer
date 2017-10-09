using System;

public class Program {
  public static bool Puzzle(int x, int y) {
int sum1=0,sum2=0;
while(x!=0)
{sum1+=x%10;x=x/10;if(sum1/10!=0 && x==0){x=sum1;sum1=0;}}
while(y!=0)
{sum2+=y%10;y=y/10;if(sum2/10!=0 && y==0){y=sum2;sum2=0;}}
	  sum1+=sum2;
	  sum2=0;
	  while(sum1!=0)
{sum2+=sum1%10;sum1=sum1/10;if(sum2/10!=0 && sum1==0){sum1=sum2;sum2=0;}}
	
	if(sum2==1)return true;
    return false;
  }
}
using System;
using System.Linq;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		foreach(int x in a)if(x!=0)list.Add(x);
		if(list.Count == 0)return 0;
		if(list.Count == 1)return list[0];
		long sum = list[0];
		int i = 0;
		if(sum%3==0)return (int)sum;
		if(sum<0){while(i<list.Count-1 && sum<list[i+1] && list[i+1]<0 ){
			sum +=list[i+1];
			i++;}}
		else{
		while(i<list.Count-1 && sum<list[i+1] )
		{
			if(list[i]==1)return 1;
			if(list[i]==2)return 2;
			if(isPower(list[i],2)&&isPower(list[i+1],2))return list[i];
			sum +=list[i+1];
			i++;}
		}
		return list[i];
		}
//		for(int i = a.Length-1;i>=0;i--)
//		{
//			if(a[i]!=1 &&a[i]!=0 && !isPower(a[i],2))return a[i];
//		}
//		for(int i = 0;i<a.Length;i++)
//		{
//			if(a[i]!=0 && isPower(a[i],2))return a[i];	
//		}
		
    
	public static bool isPower(int x,int y)
	{
		if(x==1)return true;
		while (x%y == 0)  x = x / y;
		return x == 1;
	}
}



public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
int i,j,temp,count=0;
int[] x={0};
for(i=0;i<a.length-1;i++)
{for(j=i+1;j<a.length;j++)
{if(a[i]>a[j])
{temp=a[i];
a[i]=a[j];
a[j]=temp;
}
if(a[i]==a[j] && a[i]==0)
count++;
}if(count==a.length)
{
return x[];
}
}
        return a;
    }
}
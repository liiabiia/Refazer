

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
int i,j,temp,count=0,k;
int[] x={0};
for(i=0;i<a.length;i++)
{for(j=0;j<b.length;j++)
{if(a[i]==b[j] && a.length>1)
{for(k=i;k<a.length-1;k++)
a[k]=a[k+1];
a[k]=0;
}
if(a[i]==b[j] && a.length==1)
{return ;
}
}
}
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
return x;
}
}

        return a;
    }
}
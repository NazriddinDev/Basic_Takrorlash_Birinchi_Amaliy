using System;

// 1 dan 1000 gacha toq sonlar yig'indisini hisoblash
int n, k=1, S=0;
Console.Write("Sonni kiriting => ");
n=Convert.ToInt32(Console.ReadLine());
while(k<=n)
{
    if(k%2!=0)
    {
        S=S+k;
    }
    k++;
}
Console.WriteLine(S);
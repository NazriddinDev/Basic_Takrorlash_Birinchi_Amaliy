using System;
using System.Linq;

// // 1 dan 1000 gacha toq sonlar yig'indisini hisoblash
// int n, k=1, S=0;
// Console.Write("Sonni kiriting => ");
// n=Convert.ToInt32(Console.ReadLine());
// while(k<=n)
// {
//     if(k%2!=0)
//     {
//         S=S+k;
//     }
//     k++;
// }
// Console.WriteLine(S);

// 2 Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur
int m, S;
Console.Write("Array elementlari sonini kiriting => ");
m=int.Parse(Console.ReadLine());
int[] n= new int[m];

for(int i=0; i<n.Length; i++)
{
    Console.WriteLine("Array elementlarini kiriting => ");
    n[i]=int.Parse(Console.ReadLine());
}

S=n.Max()*n.Min();
Console.WriteLine($" Arrayning katta va kichik elementlarining ko'paytmasi => {S}");
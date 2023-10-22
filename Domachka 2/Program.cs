void Standart () {
   Console.Write("Введите число: "); 
   
}
int SumCifr(int a) {
int x = a;
int res = 0;
while (x > 0) {
    res += x%10;
    x = x/10;
}
return res;
}
Standart();
int a = int.Parse(Console.ReadLine());
Console.Write(SumCifr(a));
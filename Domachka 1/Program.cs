int Step(int a, int b) {
    int i = 0;
int resul = 1;
while (i < (b)) {
    resul = resul*a;
    i = i+1;
}
return resul;
}
Console.WriteLine("Введи свои числа, самурай: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.Write("Ваше число:"+ Step(a,b));

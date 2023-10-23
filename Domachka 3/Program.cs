void Arr() {
int[] GG = new int [8];
for (int i=0; i<8; i++) {
    GG[i] = new Random().Next(1, 999);
}
for (int j = 0; j<8; j++) { 
Console.WriteLine("Число №" + j +" в массиве = "+ GG[j]);
}
}

Arr();
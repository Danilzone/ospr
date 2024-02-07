// ========== Works 1
float a, i;
a = 5;
i = 6;
Console.WriteLine(a/i);


// ========== Works 2
Console.WriteLine("5\n10\n21");

// ========== Works 3

for(int k = 1; k <=4; k++ ) {
    Console.WriteLine(k);
} 

// ========== Works 4

for(int u = 1; u <=4; u++ ) {
    Console.Write(u + " ");
} 

// ========== Works 5

int alpha, beta;
float zeta;
double teta;

Console.Write("Введите число 1: ");
alpha = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
beta = Convert.ToInt32(Console.ReadLine());

zeta = (alpha+beta)/2;
teta = 2*Math.Sqrt(zeta*beta);
Console.WriteLine("Ср. арфм.: " + zeta + "\nСр. геом.: " + teta);

// ========== Works 6

int z, x; 
Console.Write("Введите число 1: ");
z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма: " + (z+x) +
                "\nРазность: " + (z-x) +
                "\nПроизведение: " + (z*x) +
                "\nЧастное: " + (Convert.ToDouble(z)/Convert.ToDouble(x)) );

// ========== Works 7

double a1, a2, a3, P, V;
a1 = 10;
a2 = 15;
a3 = 29;

V = a1*a2*a3;
P = 2*(a1*a2 + a2*a3 + a1*a3);
Console.WriteLine("V = " + V  +
                "\nP = " + P);



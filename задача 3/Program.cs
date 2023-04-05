// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt( string message)

{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ax = ReadInt("Введите Х первой точки");
int ay = ReadInt("Введите Y первой точки");
int az = ReadInt("Введите Z первой точки");
int bx = ReadInt("Введите X второй точки");
int by = ReadInt("Введите Y второй точки");
int bz = ReadInt("Введите Z второй точки");

int koordX = (ax - bx);
int koordY = (ay - by);
int koordZ = (az - bz);

double W = Math.Sqrt(Math.Pow(koordX,2) + Math.Pow(koordY,2) + Math.Pow(koordZ,2));
System.Console.WriteLine($"Расстояние между точками: {W:f2}");
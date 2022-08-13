/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
double dlina(double x1, double y1,double z1,double x2,double y2,double z2)
{
    double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return d;
}
Console.WriteLine("Введите координаты двух точек в пространстве x1, y, z1, x2, y2, z2");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
	

Console.WriteLine("Расстояние между заданными точками равно " + Math.Round(dlina(x1,y1,z1,x2,y2,z2),3));

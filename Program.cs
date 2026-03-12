// See https://aka.ms/new-console-template for more information

static double EuclideanDistance((int, int) a, (int, int) b)
{
    double res = Math.Sqrt((Math.Pow(b.Item1 -  a.Item1,2) + Math.Pow(b.Item2 -  a.Item2,2)));
    Console.WriteLine("Distance between " + a + " and " + b + " is " + res);
    return res;
}

(int,int) vec1= (5,2);
(int,int) vec2= (1,0);

EuclideanDistance(vec1, vec2);

Random rd = new Random();

static double EuclideanDistance((int, int) a, (int, int) b)
{
    double res = Math.Sqrt((Math.Pow(b.Item1 -  a.Item1,2) + Math.Pow(b.Item2 -  a.Item2,2)));
    Console.WriteLine("Distance between " + a + " and " + b + " is " + res);
    return res;
}

((int,int), (int, int)) generateRandomVectors()
{
    return ((rd.Next(100), rd.Next(100)), (rd.Next(100), rd.Next(100)));
}

((int, int), (int, int)) vectors = generateRandomVectors();

Console.WriteLine(EuclideanDistance(vectors.Item1, vectors.Item2));

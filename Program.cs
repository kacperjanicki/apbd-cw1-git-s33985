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

Console.WriteLine("Hello world");

double CalculateAverage(int[] values)
{
    double sum = 0;
    foreach (var val in values)
    {
        sum += val;
    }
    return sum / values.Length;
}

Console.WriteLine(CalculateAverage(new []{5,3}));
Console.WriteLine("Drugi commit na feature-average");

Console.WriteLine("Something before merging feature-max");

int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be empty");

    int max = values[0];
    foreach (var value in values)
    {
        if (value > max)
        {
            max = value;
        }
    }
    return max;
}

int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be empty");

    int min = values[0];
    foreach (var value in values)
    {
        if (value < min)
        {
            min = value;
        }
    }
    return min;
}

Console.WriteLine("something before calculate-min rebase");


Console.WriteLine("something on the branch conflict");
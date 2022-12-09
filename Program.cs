class Program
{
    static CircularLinkedList<double> circ = new CircularLinkedList<double>();
    static void Main(string[] args)
    {
        Input();
        Check(int.Parse(Console.ReadLine()));
    }
    static void Input()
    {
        while (true)
        {
            double input = double.Parse(Console.ReadLine());
            if (input > 0)
            {
                circ.Add(input);
            }
            else
            {
                break;
            }
        }
    }
    static void Check(int n)
    {
        for (int i = 0; i < circ.GetLength(); i++)
        {
            double sum = 0;
            for (int j = i - n / 2; j < i + 1 + n / 2; j++)
            {
                sum += circ.Get(j) / Convert.ToDouble(n);
            }
            Console.WriteLine(sum);
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        double[,] mat = new double[5, 3];
        LerMatriz(mat);
        MostrarMatriz(mat);

        void LerMatriz(double[,] x)
        {
            for (int i = 0; i < 5; i++)
            {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Digite o ["+ i + "," + j + "] valor da matriz: ");
                        x[i, j] = double.Parse(Console.ReadLine());
                    }
            }
            for (int i = 0; i < 5;i++)
            {
                x[i,2] = x[i,0] + x[i,1];
            }
        }
        void MostrarMatriz(double[,] y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(y[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
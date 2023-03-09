internal class Program
{
    private static void Main(string[] args)
    {
        double[,] mat = new double[5, 3];

        Random sorteio = new Random();

        //Carregar valores na matriz
        for (int c = 0; c < mat.GetLength(1) - 1; c++)
        {
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                mat[l, c] = (double)sorteio.Next(1000) / 100;
            }
        }
        //Calculo da 3. Coluna
        Console.WriteLine("Calculando...");
        for (int l = 0; l < mat.GetLength(0); l ++)
        {
            mat[l,2] = (mat[l,0] + mat[l,1]) / 2;
        }

        //Impressao da matriz
        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat.GetLength(0); l++)
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(" \tmat["+l+"]["+c + "] =" + mat[l,c].ToString("F2"));
            }
            Console.WriteLine();
        }
    }
}

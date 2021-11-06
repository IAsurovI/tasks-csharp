using System;

namespace labOOP_1p1
{
    class vector
    {
        public double x;
        public double y;

        public int n;
        public double []vec;
        public vector(double x, double y, int n)
        {
            this.vec = new double[n];

            this.x = x;
            this.y = y;
            this.n = n;
        }
        public void inputNumber()
        {
            Console.WriteLine("\nВвод чисел: ");
            for (int i = 0; i < this.n; i++)
            {
                vec[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void outputNumber()
        {
            Console.WriteLine("\nВывод чисел: ");
            for (int i = 0; i < this.n; i++)
            {
                Console.WriteLine($"i[{i}]={vec[i]}");
            }
        }
        public void lengthOf()
        {
            double length = 0;
            double lengthDone = 0;
            for (int i = 0; i < this.n; i++) 
            {
                length +=vec[i]*vec[i];
                    }

            lengthDone = Math.Sqrt(length);
            Console.WriteLine($"\nДлина вектора: {lengthDone}");
        }
        public void normOf()
        {
            Console.WriteLine("\nНормированный вектор:");
            double length = 0;
            double lengthDone = 0;
            for (int i = 0; i < this.n; i++)
            {
                length += vec[i] * vec[i];
            }

            lengthDone = Math.Sqrt(length);
            for(int i = 0; i < this.n; i++)
            {
                Console.WriteLine($"i[{i}]={vec[i] / lengthDone}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("х:");
            double x= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Размерность вектора:");
            int n = Convert.ToInt32(Console.ReadLine());
            vector vec = new vector(x, y, n);

            vec.inputNumber();
            vec.outputNumber();
            vec.lengthOf();
            vec.normOf();

        }
    }
}

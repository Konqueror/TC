using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Salaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int workerCount = int.Parse(Console.ReadLine());

            Worker[] allWorkers = new Worker[workerCount];

            for (int i = 0; i < workerCount; i++)
            {
                allWorkers[i] = new Worker();
            }
            for (int row = 0; row < workerCount; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < workerCount; col++)
                {
                    if (line[col] == 'Y')
                    {
                        allWorkers[row].BossOf.Add(allWorkers[col]);
                    }
                }
            }

            BigInteger result = 0;
            for (int i = 0; i < workerCount; i++)
            {
                result += allWorkers[i].Sallary;
            }
            Console.WriteLine(result);
        }
    }
}

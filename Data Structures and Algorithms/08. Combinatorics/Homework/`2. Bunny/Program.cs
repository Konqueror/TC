using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bunny
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAsk = int.Parse(Console.ReadLine());
            Dictionary<int, int> answers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfAsk; i++)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answers.ContainsKey(answer) == false)
                {
                    answers.Add(answer, 1);
                }
                else
                {
                    answers[answer]++;
                }
            }

            int result = 0;
            foreach (var item in answers)
            {
                //Console.WriteLine("{0} zaicheta kazaha che sa obshto : {1} ednakvi", item.Value, item.Key + 1);
                double coeficient = ((double)item.Value / (item.Key + 1));
                result += (int)Math.Ceiling(coeficient) * (item.Key + 1);
            }

            Console.WriteLine(result);
        }
    }
}

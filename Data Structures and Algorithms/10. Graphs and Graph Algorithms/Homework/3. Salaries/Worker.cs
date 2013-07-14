using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Salaries
{
    class Worker
    {
        long sallary;
        List<Worker> bossOf = new List<Worker>();

        public Worker()
        {
            this.Sallary = 0;
        }

        public List<Worker> BossOf
        {
            get
            {
                return this.bossOf;
            }
            set
            {
                this.bossOf = value;
            }
        }

        private long CalculateSallary()
        {
            if (this.bossOf.Count == 0)
            {
                this.sallary = 1;
                return 1;
            }
            else
            {

                foreach (var worker in this.bossOf)
                {
                    this.sallary += worker.Sallary;
                }
                return this.sallary;
            }
        }

        public long Sallary
        {
            get
            {
                if (this.sallary == 0)
                {
                    return this.CalculateSallary();
                }
                return this.sallary;
            }
            private set
            {
                this.sallary = value;
            }
        }
    }
}

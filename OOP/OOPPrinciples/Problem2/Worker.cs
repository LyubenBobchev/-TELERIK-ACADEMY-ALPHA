using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Week salary cannot be less than or equal to zero.");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Work hours per day cannot be less than or equal to zero.");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public decimal MoneyPerHour
        {
            get
            {
                return this.moneyPerHour;
            }
            set
            {
                this.moneyPerHour = value;
            }
        }

        public decimal MoneyEarnedPerHour(decimal weekSalary, int workHoursPerDay)
        {
            decimal moneyEarnedPerHour = WeekSalary / (5 * workHoursPerDay);
            return moneyEarnedPerHour;
        }

        public override string ToString()
        {
            return  string.Format("{0} {1} - Eearns {2} lv. per hour", this.FirstName, this.LastName, this.MoneyPerHour);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employee
    {


        public string CalcSalary(string name,double salary,double salesAmount,int overTime)
        {
            double OverTimeCost =(( (salary / 30) / (8))*(overTime*1.5))+salary;

            if (salesAmount>=0 && salesAmount <1000)
            {
                salary = salary;
            }
            else if (salesAmount >= 1000 && salesAmount < 5000)
            {
                salary = salary+(salesAmount*0.02);
            }
            else if (salesAmount >= 5000 && salesAmount < 10000)
            {
                salary = salary + (salesAmount * 0.04);
            }
            else if (salesAmount >= 10000 && salesAmount < 15000)
            {
                salary = salary + (salesAmount * 0.06);
            }
            else if (salesAmount >= 15000 )
            {
                salary = salary + (salesAmount * 0.09);
            }

            return "Name: " + name+"\n Sales Amount: " + salesAmount 
                +"\n Total Salary : " +salary+
                "\n Total Salary after over Time: " + OverTimeCost
                ;
        }


    }
}

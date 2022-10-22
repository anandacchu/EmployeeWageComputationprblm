using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_num1
{
    public static class employeewage1
    {
        public static void TotalEmployeeWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int Employee_Per_Hour = 20;
            const int Employee_IS_WORKING_DAYS = 4;

            int empHrs = 0;
            int empwage = 0;
            int totalemployeewage = 0;
            int totalemployeehrs = 0;

            Random random = new Random();
            int empCheck = random.Next(3);
            //Console.WriteLine(empCheck);
            //
            // if (empCheck == IS_FULL_TIME)
            //{
            //  Console.WriteLine("Employee Present");
            //empHrs = 8;
            //}
            //
            //else if (empCheck == IS_PART_TIME)
            //{
            //  Console.WriteLine("Part_Time_Employee");
            //empHrs = 4;
            //}
            //else
            //{
            //  Console.WriteLine("Employee Absent");
            //empHrs = 0;

            // }
            for (int i = 0; i < Employee_IS_WORKING_DAYS; i++)
            {

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee Present");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Part_Time_Employee");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee Absent");
                        empHrs = 0;
                        break;
                }


                totalemployeehrs = totalemployeehrs + empHrs;
                Console.WriteLine(totalemployeehrs);

            }
            totalemployeewage = totalemployeehrs * Employee_Per_Hour;
            Console.WriteLine(totalemployeewage);

    
           
        }
       
        
    }
}

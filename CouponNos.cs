﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class CouponNos
    {
        public static void CouponNumber()
        {
            Console.WriteLine("Enter the end of coupon no: ");
            int number=int. Parse(Console.ReadLine());
            int n = 0;
            int[] coupons =new int[number];
            Random r = new Random();
            int num_count=0;
            while(n<number)
            {
                int randomnumber=r.Next(number+1);
                num_count++;
                if(coupons.Contains(randomnumber))
                {
                    continue;
                }
                else 
                {
                    coupons[n] = randomnumber;

                }
                n++;
            }
            foreach(int coupon in coupons)
            {
                Console.WriteLine(coupon+" ");
            }
           Console.WriteLine("the count needed to generate is: "+num_count);
              
               
        }
    }
}

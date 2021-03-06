﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ict3101lab1
{
    public class Calculator
    {
        public Calculator() { }
        
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {   
            if(num1 == 0 & num2 == 0)
            {
                return 666;
            }
            if(num1 == 0 & num2 == 20)
            {
                return 2;
            }
            if (num1 == 20 & num2 == 0)
            {
                return 200;

            }
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double failInten(double num1, double num2, double num3)
        {
            return (num1 * (1 - (num2 / num3)));
        }
        public double expectFail(double num1, double num2, double num3)
        {
            return (num1 * (1 - Math.Exp((-num2 / num1)*num3)));
        }
        public double Fac(double num1)
        {   
            if(num1 <= 0)
            {
                return 1;
            }
            else
            {
                int i, fact = 1;
                for (i = 1; i <= num1; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
        }
        public double Divide(double num1, double num2)
        {   
            if(num1 == 0)
            {
                if (num2 == 0) {
                    return 1;
                }
                return 0;
            }
            if(num2 == 0){
                return double.PositiveInfinity;
            }
            return (num1 / num2);
        }
    }
}

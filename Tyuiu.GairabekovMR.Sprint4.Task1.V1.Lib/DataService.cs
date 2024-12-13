﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GairabekovMR.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int esum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    esum += array[i];
                }
            }
            return esum;
        }
    }
}
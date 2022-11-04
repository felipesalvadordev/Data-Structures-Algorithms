﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Algorithms.Algorithms
{
    public class FruitIntoBasket
    {
        //Sliding window concept, simply with two pointers (last_fruit && second_last_fruit)
        public void Test()
        {
            //int[] trees = { 1, 2, 3, 2, 2 }; //Pick 4. We can pick from trees [2,3,2,2].
            int[] trees = { 0, 1, 2, 2 };//Pick 3.We can pick from trees [1,2,2].
            var total = TotalFruit(trees);
            Console.WriteLine(total);
        }

        public int TotalFruit(int[] tree)
        {
            var last_fruit = -1;
            // the last fruit which we saw
            var second_last_fruit = -1;
            // the second last fruit which we saw
            var last_fruit_count = 0;
            // the number of last fruits present
            var current_max = 0;
            // current count of the two types of fruits
            var max = 0;
            // the ans returning maximum count
            foreach (int fruit in tree)
            {
                // if the current fruit is same as last fruit and second last fruit we increment the count
                if (fruit == last_fruit || fruit == second_last_fruit)
                {
                    current_max++;
                }
                else
                {
                    current_max = last_fruit_count + 1;
                }
                // here we check for the last fruit count
                if (fruit == last_fruit)
                {
                    last_fruit_count++;
                }
                else
                {
                    last_fruit_count = 1;
                }
                // if a new fruit is found in the list then we change second last fruit to
                // last fruit and current fruit to the last fruit
                if (fruit != last_fruit)
                {
                    second_last_fruit = last_fruit;
                    last_fruit = fruit;
                }
                max = Math.Max(max,current_max);
            }
            return max;
        }
    }
}

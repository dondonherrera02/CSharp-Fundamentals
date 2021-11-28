﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd". Go to the editor
    Sample Input:
    "abcd"
    "abc"
    "a"
    Expected Output:
    aababcabcd
    aababc
    a
     */
    public class BasicAlgo_0030_AABABCABCD
    {
        public static void Main(string[] args)
        {
            var collection = new string[]
            {
                "abcd",
                "abc",
                "a"
            };

            foreach (var item in collection)
            {
                Console.WriteLine(ProduceAbcd(item));
            }
        }

        public static string ProduceAbcd(string request)
        {
            var result = new List<string>();
            for (int i = 1; i < request.Count()+1; i++)
            {
                var a = request.Substring(0, i);
                result.Add(a);
            }

            return string.Join("", result);
        }
    }
}

using System;
using System.Collections.Generic;

namespace ShallowAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list;

            Recipe r1 = new Recipe("beer", list = new List<string>() {"water","alcohol" });
            Recipe r2 = new Recipe("pizza", list = new List<string>() { "3,14159265","zza(?)" });
            Recipe r3 = new Recipe("bolognese", list = new List<string>() {"noodles","tomato sauce","crushed meat", "spices"});
            Recipe r4 = new Recipe("horse C**", list = new List<string>() {"speed","4 long legs (+1)","oat","2 ahyes" });
            Recipe r5 = new Recipe("number 5", list = new List<string>() {"5 what?","4","3..." });
            Console.WriteLine(r5.ToString()+"\n\n\n");
            
            Recipe r6 = (Recipe)r5.Clone();
            r6.ingredients.Clear();
            
            Console.WriteLine(r5);
            Console.WriteLine(r6);
        }
    }
}

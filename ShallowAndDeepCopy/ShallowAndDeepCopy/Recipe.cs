using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShallowAndDeepCopy
{
    class Recipe :ICloneable
    {
        private int id;
        private string name;
        public List<string> ingredients = new List<string>();

        public Recipe()
        {


        }
        public Recipe(string n,List<string>i)
        {
            this.id = Random_ID();
            this.name = n;
            this.ingredients = i;

        }
        public override string ToString()
        {
            string mamamia =string.Join(", ", ingredients);
            return $"ID:{id} \tname:{name}\tingredients:{mamamia}";
        }
        
        private int Random_ID()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100000);
            return number;
            
        }

        

        public object Clone()
        {
            Recipe copy = new Recipe();
            copy.id = this.id;
            copy.name = this.name;
            copy.ingredients = this.ingredients;
            return copy;
        }
    }
}

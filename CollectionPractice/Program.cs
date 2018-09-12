using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "Martin" };
            var firstInList = list[0];

            var spouces = new Dictionary<MiniFigure, Minifigure>();

            var todd = new MiniFigure();
            var robin = new MiniFigure();
            spouces.Add(todd, robin);

            var spouceKeys = spouces.Keys;

            var success = spouces.TryGetValue(todd, out MiniFigure robin);
            var canParse = Int32.TryParse("42", out var realInt);
        }

        public class MiniFigure
        {
            //something here
        }
    }
}

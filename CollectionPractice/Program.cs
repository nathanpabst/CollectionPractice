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

            var spouces = new Dictionary<MiniFigure, MiniFigure>();

            var todd = new MiniFigure();
            var robin = new MiniFigure();
            spouces.Add(todd, robin);

            var spouceKeys = spouces.Keys;

            var success = spouces.TryGetValue(todd, out MiniFigure robin);
            var canParse = Int32.TryParse("42", out var realInt);

            var name = Tuple.Item1;
            var number = Tuple.Item2;

            var martinExists = list.Exists(x => x == "Martin") && list.Capacity > 0 || list.Count > 0;
            if (martinExists)
            {
                DoSomething();
            }
        }
        static void DoSomething()
        {
            //properties/methods here
        }

        public class MiniFigure
        {
            //something here
        }
    }
}

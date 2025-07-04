namespace Algorithms
{
    public class Deadfish
    {
        public static int[] Parser(string input)
        {
            int val = 0;
            //int[] result = new int[input.Count(c => c == 'o')];
            List<int> result = new List<int>();
            
            //foreach(var item in input)
            //{
            //    if (item == 'i')
            //    {
            //        val++;
            //    }
            //    else if (item == 'd')
            //    {
            //        val--;
            //    }
            //    else if (item == 's')
            //    {
            //        val *= val;
            //    }
            //    else if (item == 'o')
            //    {
            //        //result[i] = val;
            //        result.Add(val);
            //    }
            //}
            //for (int i = 0; i < input.Length; i++)
            //{
            //    var command = input[i];

            //    if (command == 'i')
            //    {
            //        val++;
            //    }
            //    else if (command == 'd')
            //    {
            //        val--;
            //    }
            //    else if (command == 's')
            //    {
            //        val *= val;
            //    }
            //    else
            //    {
            //        result.Add(val);
            //    }
            //}
            return result.ToArray();
        }

        public int[] AggregateParser(string input)
        {
            //int val = 0;
           // List<int> result = new List<int>();


            // Using Aggregate to process the input string
            var aggregate = input.Aggregate((val:0, res:new List<int>()), (acc, currentItem) => 
            {
                if (currentItem == 'i')
                {
                    acc.val++;
                }
                else if (currentItem == 'd')
                {
                    acc.val--;
                }
                else if (currentItem == 's')
                {
                    acc.val *= acc.val;
                }
                else if (currentItem == 'o')
                {
                    acc.res.Add(acc.val);
                }
                return acc;
            });

            return aggregate.res.ToArray();
        }

        public static int AddCollectionVal(int[] val)
        {
            return val.Aggregate(0, (acc, current) => acc + current);
        }
    }
}

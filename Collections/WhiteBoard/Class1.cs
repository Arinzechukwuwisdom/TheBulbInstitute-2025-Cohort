using System.Collections.ObjectModel;

namespace WhiteBoard
{
    public class Class1
    {
        public void Something()
        {
            var class2 = new Class2
            {
                
                MyProperty = 1,
                MyProperty1 = 2,
                MyProperty2 = 3
            };

            //Collections
            //Arrays
            //Lists

            //Some collections are generic while some are non generic
            List<Class2> database = new List<Class2>
            {
                class2,
                new Class2
                {
                    MyProperty = 1, 
                    MyProperty1 = 4,
                    MyProperty2= 4
                },
                new Class2{MyProperty = 1, MyProperty1 = 4, MyProperty2= 4},
                new Class2{MyProperty = 1, MyProperty1 = 4, MyProperty2= 4},
                new Class2{MyProperty = 1, MyProperty1 = 4, MyProperty2= 4},
            };

            database.Add(class2);

        }
    }
    public class Class2
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
}

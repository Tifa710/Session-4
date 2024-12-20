namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Loop Statment
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}T");
            }
            #endregion
            #region For - Foreach [Array]
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < Numbers.Length; i++)
            {
                //Numbers[i] += 10;
                if (Numbers[i] == 5)
                {
                    //break;
                    continue;
                }
                //Console.WriteLine(Numbers[i] + 10);
                Console.WriteLine(Numbers[i]);
            }

            //We Can Use Foreach in Class - Implement - Interface -> IEnumrable 
            foreach (int Number in Numbers)
            {
                //Number += 10;  //Foreach can't edit bc it works on origin array
                Console.WriteLine(Number + 10);
            }

            #endregion
            #region While - Do While
            int Number;
            bool Flag;
            do
            {
                Console.WriteLine("Enter Even Number");
                //Number = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out Number);
                Flag = int.TryParse(Console.ReadLine(), out Number);
            }
            while (Number % 2 == 1 || !Flag);
            Console.WriteLine($"{Number} is Even");

            int Number = 3;
            bool Flag = false;
            while (Number % 2 == 1 || !Flag)
            {
                Console.WriteLine("Enter Even Number ");
                Flag = int.TryParse(Console.ReadLine(), out Number);
            }

            Console.WriteLine($"{Number} is Even");

            #endregion
            #region String
            Class => Reference Type
            Immutable Data Type => [Value can't be Changed]
             Array of Chars
             A H M E D

            string Name;

            //Name = new string("Ahmed");

            Name = "Ahmed";

            string Name01 = "Ahmed";
            string Name02 = "Ahmed";

            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            string Name01 = "Ahmed";
            string Name02 = "Ali";

            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            Name02 = Name01; // Name02 => unreachable variable

            Console.WriteLine("*********** Name02 = Name01 ***********");
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            Name01 = "Mostafa";

            Console.WriteLine("*********** Name01 = Mostafa ***********");
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            string Message = "Hello";

            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());

            Message += " Route";


            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder [Linked List of Chars]
            StringBuilder Message;

            Message = new StringBuilder("Hello");
            //Message = "Ahmed";

            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());

            // Message += " Route";
            Message.Append(" Route");

            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder Method
            StringBuilder Message = new StringBuilder("Welcome");

            Message.Append(" To Route");
            //Console.WriteLine(Message);

            Message.AppendLine(" Mostafa");
            //Console.WriteLine(Message);

            Message.Append(" Hany");
            //Console.WriteLine(Message);

            Message.Remove(0, 7);
            //Console.WriteLine(Message);

            Message.Insert(0, "Hello");

            int Age = 10;
            string Name = "Ali";
            Message.AppendFormat("Name : {0} , Age : {1}", Name, Age);

            Message.AppendJoin("/", "Mostafa", "Hany", "Mohamed", 2);
            Console.WriteLine(Message);


            #endregion
            #region Array 1 D  [Class - Reference Type]
            int[] Numbers = new int[3] { 1, 2, 3 };
            int[] Numbers = new int[] { 1, 2, 3 };
            int[] Numbers = { 1, 2, 3 };

            int[] Numbers = new int[3];
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;

            for (int i = 0; i < Numbers.Length; i++)
            {
                //Numbers[i] = i + 1;
                Console.WriteLine($"Enter your numbers {i + 1} ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("*");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            Console.WriteLine(Numbers.Length);
            Console.WriteLine(Numbers.Rank);
            #endregion
            #region Array 2D
            int[,] Marks = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 100, 200, 300, 400, 500 } };

            Console.WriteLine(Marks.Length);
            Console.WriteLine(Marks.Rank);
            Console.WriteLine(Marks.GetLength(0));
            Console.WriteLine(Marks.GetLength(1));

            int[,] Marks = new int[3, 5];

            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Grades Student ({i + 1})");
                for (int k = 0; k < Marks.GetLength(1); k++)
                {
                    bool Flag;
                    Console.WriteLine($"Enter Grades Subject ({k + 1})");
                    //Marks[i, k] = int.Parse(Console.ReadLine());
                    Flag = int.TryParse(Console.ReadLine(), out Marks[i, k]);

                    //if (Flag && Marks[i, k] >= 0) 
                    //{
                    //    k++;
                    //}

                    k = Flag && Marks[i, k] >= 0 ? k++ : k;
                }
            }

            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"Grades Student ({i + 1})");
                for (int k = 0; k < Marks.GetLength(1); k++)
                {
                    Console.WriteLine($"Grades Subject ({k + 1})");
                    Marks[i, k] = int.Parse(Console.ReadLine());
                    Console.WriteLine(Marks[i, k]);
                }
            }

            Console.Clear();
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine(Marks[i / Marks.GetLength, i % Marks.GetLength]);
            }

            #endregion
            #region Judged Array
            int[][] Number = new int[3][];

            Number[0] = new int[3] { 1, 2, 3 };
            Number[1] = new int[2] { 4, 5 };
            Number[2] = new int[1] { 6 };

            for (int i = 0; i < Number.Length; i++)
            {
                for (int j = 0; j < Number[i].Length; j++)
                {
                    Console.WriteLine(Number[i][j]);
                }
            }
            #endregion
            #endregion
        }
    }
}

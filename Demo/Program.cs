namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++) 
            //{
            //    Console.Write(i);
            //    if (i < number) {
            //        Console.Write("\n"); 
            //    } 
            //}
            #endregion
            #region Q2
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine()); 
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);
            //    if (i < 12) 
            //    {
            //        Console.Write("\n"); 
            //    }
            //}
            #endregion
            #region Q3
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= number; i += 2) {
            //    Console.Write(i); 
            //    if (i < number - 1)
            //    {
            //        Console.Write("\n"); 
            //    }
            //}
            #endregion
            #region Q4
            //Console.Write("Enter the base number: "); 
            //int baseNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Power: ");
            //int Power = int.Parse(Console.ReadLine()); 
            //int result = 1;
            //for (int i = 0; i < Power; i++)
            //{ 
            //    result *= baseNumber; 
            //}
            //Console.WriteLine($"{baseNumber} ^ {Power} = {result}");
            #endregion
            #region Q5
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string reversedString = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString += input[i];
            //}
            //Console.WriteLine("Reversed string: " + reversedString);
            #endregion
            #region Q6
            //Console.Write("Input starting number of range: "); 
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true; if (i <= 1)
            //    { 
            //        isPrime = false;
            //    }
            //    else 
            //    {
            //        for (int j = 2; j * j <= i; j++) 
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;  
            //            }
            //        }
            //    }
            //    if (isPrime)
            //    { 
            //        Console.Write(i + "\n"); 
            //    } 
            //}
            #endregion
            #region Q7
            //Console.Write("Enter a number to convert: "); 
            //int number = int.Parse(Console.ReadLine());
            //string binary = "";
            //while (number > 0) 
            //{
            //    binary = (number % 2) + binary;
            //    number /= 2; 
            //}
            //Console.WriteLine("The Binary of the given number is " + binary);
            #endregion
            #region Q8
            //Console.Write("Enter the size of the identity matrix: "); 
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++) 
            //{ 
            //    for (int j = 0; j < n; j++) 
            //    {
            //        if (i == j) 
            //        { 
            //            Console.Write("1 ");
            //        } 
            //        else
            //        {
            //            Console.Write("0 "); 
            //        } 
            //    } 
            //    Console.WriteLine();
            //}
            #endregion
            #region Q9
            // مش فاهم مطلوب مننا نعمل اي 
            #endregion
            #region Q10
            //Console.Write("Enter the first string: "); 
            //string firstString = Console.ReadLine(); 
            //Console.Write("Enter the second string: ");
            //string secondString = Console.ReadLine(); 
            //string Final = firstString + " " +secondString;
            //Console.WriteLine("Final string: " + Final);
            #endregion
            #region Q11
            //Console.Write("Enter the size of the identity matrix: "); 
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++) 
            //{ 
            //    for (int j = 0; j < n; j++) 
            //    {
            //        if (i == j) 
            //        { 
            //            Console.Write("1 ");
            //        } 
            //        else
            //        {
            //            Console.Write("0 "); 
            //        } 
            //    } 
            //    Console.WriteLine();
            //}
            #endregion
            #region Q12
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum = 0; 
            //for (int i = 0; i < array.Length; i++) 
            //{
            //    sum += array[i]; 
            //}
            //Console.WriteLine("The sum of all elements in the array is: " + sum);
            #endregion
            #region Q13
            //int[] array1 = { 1, 3, 5, 7, 9 }; 
            //int[] array2 = { 2, 4, 6, 8, 10 }; 
            //int[] mergedArray = new int[array1.Length + array2.Length];
            //int index = 0; 
            //for (int i = 0; i < array1.Length; i++) 
            //{ 
            //    mergedArray[index++] = array1[i];
            //} 
            //for (int i = 0; i < array2.Length; i++)
            //{ 
            //    mergedArray[index++] = array2[i];
            //} Console.WriteLine("Merged array:");
            //foreach (var num in mergedArray) 
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            #region Q14

            #endregion
            #region Q15
            //int[] array = { 5, 3, 8, 1, 9, 2, 7 };
            //int max = array[0];
            //int min = array[0]; 
            //for (int i = 1; i < array.Length; i++) 
            //{ 
            //    if (array[i] > max) 
            //    { 
            //        max = array[i];
            //    } 
            //    if (array[i] < min) 
            //    { 
            //        min = array[i]; 
            //    } 
            //}
            //Console.WriteLine("Maximum Index in the array is: " + max); 
            //Console.WriteLine("Minimum Index in the array is: " + min);
            #endregion
            #region Q16
            //int[] array = { 5, 3, 8, 1, 9, 2, 7 };
            //Array.Sort(array);
            //int secondLargest = array[array.Length - 2]; 
            //Console.WriteLine("The second largest element in the array is: " + secondLargest);
            #endregion
            #region Q17

            #endregion 
            #region Q18

            #endregion
            #region q19
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Array in reverse order:"); 
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            #endregion
        }
    }
}

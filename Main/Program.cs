//using static System.Runtime.InteropServices.JavaScript.JSType;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using EntityFramworkDay_1;

namespace Main
{
    struct Point
    {
        public int i;
        public double d;
    }
    delegate int Transformer(int x);
    internal class Test
    {
        static public int Square(int x) => x * x;
    }
    internal class Test2
    {
        public int X { get; set; }
        public int Square(int x) => x * x;
    }
    public delegate T Transformer<T>(T args);
    internal class Util
    {
        public static T[] Trasnform<T>(T[] nums, Transformer<T> t)
        {
            T[] result = new T[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = t(nums[i]);
            }

            return result;
        }
        // or I just can use built-in delegate like Func without declaring my own cutom delegate
        public static T[] TrasnformUsingFunc<T>(T[] nums, Func<T, T> t)
        {
            T[] result = new T[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = t(nums[i]);
            }
            return result;
        }
    }
    internal class Program
    {
        static void Replacenums(ref int[] arr)
        {
            arr[0] = 4;
            arr[1] = 5;
            arr[2] = 6;

            //arr = null ; 
        }
        static void Swap(ref string a, ref string b)
        {
            //string temp = a;
            //a = b;
            //b = temp;
            a = "omar";
            b = "ahmed";
        }
        static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
        static void Main(string[] args)
        {
            #region difference between double , float and decimal
            //float f = 0.1f;
            //Console.WriteLine(f + f + f + f + f +
            //                  f + f + f + f + f); // => 1.0000001

            //double d = 0.1;
            //Console.WriteLine(d + d + d + d + d +
            //                  d + d + d + d + d); // => 0.9999999999999999

            //decimal m = 0.1m;
            //Console.WriteLine(m + m + m + m + m +
            //                  m + m + m + m + m); // => 1.0 
            #endregion

            #region struct initialize
            //Point p = new Point();
            //Console.WriteLine(p.i);
            //Console.WriteLine(p.d); 
            #endregion

            #region passing refernce types by value and ref
            ////int[] nums = new int[]{ 1, 2, 3 };

            ////Replacenums(ref nums );


            ////Console.WriteLine(nums[0]);
            ////Console.WriteLine(nums[1]);
            ////Console.WriteLine(nums[2]);

            //string x = "Penn";
            //string y = "Teller";
            //Swap(ref x, ref y);
            //Console.WriteLine( x); // Teller
            //Console.WriteLine( y); // Penn 
            #endregion

            #region max values of int and long and over flow problem
            //Console.WriteLine($"long max value is : {long.MaxValue}");  // ==> 9223372036854775807
            //Console.WriteLine($"int max value is : {int.MaxValue}");   // ==> 2147483647

            //// long max value ==> 9223372036854775807 ;
            //long l = long.MaxValue; //  ==> 9223372036854775807

            //int i = (int)l; // why doesn't it take max value of int and neglect the rest ? 

            //Console.WriteLine($"the new value of i : {i}");  // ==> i = -1

            //Console.WriteLine("=======================================");
            #endregion

            #region delegate
            // int Square(int x)
            // {
            //     return x * x;
            // }

            // int SquareNumber(int x) => x * x;

            // int cube(int x) => x * x * x;

            // Transformer t1 = new Transformer(Square);        //the property target in t4 holds null  because it's there no instance
            // Transformer t2 = new Transformer(SquareNumber); //the property target in t4 holds null because it's there no instance

            // Console.WriteLine(t1.Invoke(5));
            // Console.WriteLine(t2(10));

            // int[] values = { 1, 2, 3 };

            // Transform(values, cube);
            // Transform(values, Square);

            // //foreach (int x in values)
            // //{
            // //    Console.WriteLine(x);
            // //}

            // Console.WriteLine("---------------------");

            // Transformer t3 = Test.Square;   //the property target in t4 holds null because it's there no instance from the static class

            // Console.WriteLine(t3(12));

            // Test2 testObj = new Test2() { X = 5 };

            // Transformer t4 = testObj.Square;  // the property target in t4 holds the class name {Main.Test2}

            // Console.WriteLine(t4(9));

            // Console.WriteLine("-----------------------------------------");

            // int[] numbers = { 1, 2, 3, 4, 5, 6 };
            // int[] result = new int[numbers.Length];

            //result =  Util.Trasnform<int>(numbers, Square);
            // foreach (int i in result)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("---------------");
            // result = Util.Trasnform<int>(numbers, cube);
            // foreach (int i in result)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("-----------------------------------------");

            // //trying again using Func 
            // // no need to declare mt own cutome delegate
            // int[] numbers2 = { 1, 2, 3, 4, 5, 6 };
            // int[] result2 = new int[numbers2.Length];
            // result2 = Util.TrasnformUsingFunc<int>(numbers2, Square);
            // foreach (int i in result2)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("---------------");
            // result2 = Util.TrasnformUsingFunc<int>(numbers2, cube);
            // foreach (int i in result2)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("-----------------------------------------"); 
            #endregion

            #region Convert and TryParse
            //string value = "1123";
            //if(int.TryParse(value , out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("can't parse ! ");
            //}

            //Console.WriteLine(result );

            //=====================================

            //string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            //float Total = 0 ;
            //string Message = "";

            //for(int i = 0;i < values.Length; i++)
            //{
            //    if (float.TryParse(values[i] , out float numeric))
            //    {
            //        Total += numeric;
            //    }
            //    else
            //    {
            //        Message += values[i];
            //    }
            //}
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"Total : {Total}");

            //=====================================


            ////Replace the code comments in the starter code with your own code to solve the challenge:

            ////Solve for result1: Divide value1 by value2, display the result as an int
            ////Solve for result2: Divide value2 by value3, display the result as a decimal
            ////Solve for result3: Divide value3 by value1, display the result as a float


            ////Output

            ////Divide value1 by value2, display the result as an int: 2
            ////Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
            ////Divide value3 by value1, display the result as a float: 0.35833335

            //int value1 = 12;
            //decimal value2 = 6.2m;
            //float value3 = 4.3f;

            //// Your code here to set result1
            //// Hint: You need to round the result to nearest integer (don't just truncate)
            //int result1 = value1 / Convert.ToInt32(value2);
            //Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            //// Your code here to set result2
            //decimal result2 = value2 / Convert.ToDecimal(value3);
            //Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            //// Your code here to set result3
            //float result3 = value3 / value1 ;
            //Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); 

            //================================================== 
            #endregion

            #region trying some array and string functions
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //foreach (int i in nums)
            //{
            //    Console.Write($"{i}\t");
            //}
            //Console.WriteLine("\n");

            //Array.Clear(nums, 0, nums.Length);

            //foreach (int i in nums)
            //{
            //    Console.Write($"{i}\t");
            //}
            //Console.WriteLine("\n");


            //string[] pallets = { "B14", "A11", "B12", "A13" };
            //Console.WriteLine("");

            //Console.WriteLine($"Before: {pallets[0].ToLower()}");
            //Array.Clear(pallets, 0, 2);
            //if (pallets[0] != null)
            //   Console.WriteLine($"After: {pallets[0].ToLower()}");

            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}


            //string[] pallets = { "B14", "A11", "B12", "A13" };
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6);
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}


            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //string newArr = new string(valueArray);
            //Console.WriteLine(newArr);


            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);

            //string newArr = String.Join(",", valueArray);

            //Console.WriteLine(newArr);

            //string[] items = newArr.Split(',');

            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}


            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //// string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);

            //string pangram = "The quick brown fox jumps over the lazy dog";
            //string[] reversed = pangram.Split(" ");
            //for (int i = 0 ; i < reversed.Length; i++ )
            //{
            //   char[] words = reversed[i].ToCharArray();
            //    Array.Reverse(words);
            //    Console.WriteLine(words);
            //}


            //string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            //string[] items = orderStream.Split(',');

            //Array.Sort(items);

            //for(int i = 0; i < items.Length; i++)
            //{
            //    if (items[i].Length != 4)
            //        Console.WriteLine($"{items[i]} - Error");

            //    else Console.WriteLine($"{items[i]}");
            //}

            //A345
            //B123
            //B177
            //B179
            //C15 - Error
            //C234
            //C235
            //G3003 - Error


            //string first = "Hello";
            //string second = "World";
            //string result = string.Format("{0} {1}!", first, second);
            //Console.WriteLine(result);


            //decimal m = 11516m;
            //float f = 23123.23248f;

            //Console.WriteLine($"slary is : {m:c} and bouns is : {f:N4}");


            //Console.WriteLine($"slary is : {m:c} and bouns is : {f:p3}");


            //decimal price = 67.55m;
            //decimal salePrice = 59.99m;

            //string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            //Console.WriteLine(yourDiscount);

            //string input = "Omar Ahmed";

            //Console.WriteLine(input.PadLeft(input.Length + 2,'-'));
            //Console.WriteLine(input.PadRight(12, '-'));


            //string message = "Find what is (inside the parentheses)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');

            //Console.WriteLine(openingPosition);
            //Console.WriteLine(closingPosition);


            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length+1));


            //const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            //string quantity = "";
            //string output = "";

            //// Your work here

            //string openSpan = "<span>";
            //string closedSpan = "</span>";

            //int quantityStart = input.IndexOf(openSpan) + openSpan.Length ;
            //int quantityEnd = input.IndexOf(closedSpan) ;

            //int quantityLength = quantityEnd - quantityStart ;

            //quantity = input.Substring(quantityStart, quantityLength);


            //string openDiv = "<div>";
            //string closedDiv = "</div>";

            //int outputStart = input.IndexOf(openDiv) + openDiv.Length ;
            //int outputEnd = input.IndexOf(closedDiv) ;
            //int outputLength = outputEnd - outputStart ;

            //output = input.Substring(outputStart, outputLength);

            //Console.WriteLine(quantity);
            //Console.WriteLine(output);

            //Quantity: 5000
            //Output: < h2 > Widgets & reg;</ h2 >< span > 5000 </ span > 

            #endregion

            #region IEnumrator
            //string word = "Omar";

            //IEnumerator enumrator = word.GetEnumerator();

            //enumrator.MoveNext();

            //object currentObject = enumrator.Current;

            //Console.WriteLine(currentObject);

            //enumrator.MoveNext() ;

            //currentObject = enumrator.Current;

            //Console.WriteLine(currentObject);

            //string word = "Omar";

            //IEnumerator enumrator = word.GetEnumerator();

            //object currentObject;

            //while (enumrator.MoveNext())
            //{
            //    currentObject = enumrator.Current;

            //    Console.WriteLine(currentObject);
            //} 


            #endregion

            #region threads and stackframes
            //foreach (Process p in Process.GetProcesses())
            //    using (p) // calls Dispose() from IDispoable to ensure that resources are cleared after using it 
            //    {
            //        Console.WriteLine($"Process name : {p.ProcessName}");
            //        Console.WriteLine(" PID: " + p.Id);
            //        Console.WriteLine(" Memory: " + p.WorkingSet64);
            //        Console.WriteLine(" Threads: " + p.Threads.Count);
            //        Console.WriteLine("-----------------");
            //        EnumerateThreads(Process.GetCurrentProcess());
            //        Console.WriteLine("==============================================");
            //    }

            //void EnumerateThreads(Process p)
            //{
            //    foreach (ProcessThread pt in p.Threads)
            //    {
            //        Console.WriteLine("ProcessThread ID : " + pt.Id);
            //        Console.WriteLine(" State: " + pt.ThreadState);
            //        Console.WriteLine(" Priority: " + pt.PriorityLevel);
            //        Console.WriteLine(" Started: " + pt.StartTime);
            //        Console.WriteLine(" CPU time: " + pt.TotalProcessorTime);
            //    }
            //}

            //first(); 

            //=========================================
            //Thread t = new Thread(WriteY);
            //t.Name = "test1";
            //t.Start();
            ////Thread.Sleep(1000);
            ////Console.WriteLine($" {Thread.CurrentThread.Name}");
            ////t.Join();
            ////Console.WriteLine("End thread first ");
            ////doing any thinf in the main thread
            //for (int i = 0;i < 1000;i++)
            //{
            //    Console.Write("X");
            //}

            //ThreadStart ts = new ThreadStart (WriteY);


            //ParameterizedThreadStart p = new ParameterizedThreadStart();

            //Thread th = new Thread(() => print("Omar"));

            //th.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("X");
            //}

            //new Thread(() =>
            //{
            //    Console.WriteLine("I'm running on another thread!");
            //    Console.WriteLine("This is so easy!");
            //}).Start();

            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("Hello from other thread");
            //    Console.WriteLine("I am in a multi-line lambda expression ");
            //});
            //t.Start();

            //Thread t = new Thread(print);
            //t.Start("Omar");  //An alternative (and less flexible) technique is to pass an argument into Thread’s  Start method:
            ////t.Start("Omar");


            //======================================================
            // captured variables

            //for (int i = 0; i < 10; i++)
            //{
            //    new Thread(() => Console.Write(i)).Start();  //24255699910  captured variables problem
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < 10; i++)
            //{
            //    int temp = i;
            //    new Thread(() => Console.Write(temp)).Start();  // 0123456789 the sol is to use temp variable to be local to each loop and the thread captures a different memory location
            //}
            //Console.WriteLine("\n");

            //======================================================


            //string text = "t1";
            //Thread t1 = new Thread(() => Console.WriteLine($"Hello {text}"));

            //text = "t2";
            //Thread t2 = new Thread(() => Console.WriteLine($"Hello {text}"));

            //t1.Start(); 
            //t2.Start();
            //Because both lambda expressions capture the same text variable, t2 is printed twice.

            //======================================================

            //try
            //{
            //    new Thread(GO).Start();
            //}
            //catch (Exception e)
            //{
            //    // We'll never get here!
            //    //The try/catch statement in this example is ineffective, and the newly created thread
            //    //will be encumbered with an unhandled NullReferenceException. This behavior
            //    //makes sense when you consider that each thread has an independent execution
            //    //path.

            //    Console.WriteLine("exception handeled by using try catch in the main thread ");
            //}

            //============================================================

            //Thread worker = new Thread(() => Console.ReadLine());
            //worker.IsBackground = false;

            //worker.Start();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("X");
            //}

            //============================================================

            //// Task is in System.Threading.Tasks
            //Task.Run(() => Console.WriteLine("Hello from the thread pool"));

            ////Because tasks didn’t exist prior to .NET Framework 4.0, a common alternative is to
            ////call ThreadPool.QueueUserWorkItem:
            //ThreadPool.QueueUserWorkItem(notUsed => Console.WriteLine("Hello"));

            //Task.Run(() => Console.WriteLine("Foo")); // hot task 
            //Console.ReadLine();

            //Tasks use pooled threads by default, which are background
            //threads.This means that when the main thread ends, so do
            //any tasks that you create. Hence, to run these examples from
            //a console application, you must block the main thread after
            //starting the task(for instance, by Waiting the task or by call‐
            //ing Console.ReadLine):  

            //Task t1 = new Task(()=> Console.WriteLine("foo"));  // cold task using task constructor
            //t1.RunSynchronously();  // don't need to make the main blocked

            //Task t = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Foo");
            //});

            //Console.WriteLine(t.IsCompletedSuccessfully);
            //Console.WriteLine(t.IsCompleted);

            //t.Wait();

            //Console.WriteLine(t.IsCompletedSuccessfully);
            //Console.WriteLine(t.IsCompleted);

            //for (int i = 0;i<1000;i++)
            //    Console.Write("x");


            //Task<int> task = Task.Run(() =>
            //{
            //    Console.WriteLine("Foo");
            //    return 3;
            //});

            //int result = task.Result;

            //Console.WriteLine(result);

            //------------------

            //Task task = Task.Run(()=> 
            //{
            //    throw null;
            //});

            //try
            //{
            //    task.Wait();
            //}
            //catch (AggregateException aex)
            //{
            //    if (aex is NullReferenceException)
            //        Console.WriteLine("Handeked Exception in task wait");
            //    else
            //        throw;
            //}


            // Start a Task that throws a NullReferenceException:
            //Task task = Task.Run(() => { throw null; });
            //try
            //{
            //    task.Wait();
            //}
            //catch (AggregateException aex)
            //{
            //    if (aex.InnerException is NullReferenceException)
            //        Console.WriteLine("Null!");
            //    else
            //        throw;
            //}
            ////for (int i = 0; i< 1000; i++)
            ////    Console.WriteLine("x");

            //============================================================

            //Task<int> primeNumberTask = Task.Run(() =>
            //Enumerable.Range(2, 3000000).Count(n =>
            //Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
            //var awaiter = primeNumberTask.GetAwaiter();
            //awaiter.OnCompleted(() =>
            //{
            //    int result = awaiter.GetResult();
            //    Console.WriteLine(result); // Writes result
            //});

            //------------------
            //Task<int> primeNumberTask = Task.Run(() =>
            //Enumerable.Range(2, 3000000).Count(n =>
            //Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));

            //var awaiter = primeNumberTask.ConfigureAwait(false).GetAwaiter();

            //primeNumberTask.ContinueWith(antecedent =>
            //{
            //    int result = antecedent.Result;
            //    Console.WriteLine(result); // Writes 123
            //});
            //------------------------------

            //Task<int> task = Task.Run(() =>
            //{
            //   for(int i = 0;i < 10;i++)
            //        Console.Write("X");

            //    return 10;
            //});

            //var awaiter = task.GetAwaiter();

            //awaiter.OnCompleted(async () =>
            //{
            //    int result = awaiter.GetResult();
            //    Console.WriteLine(result);
            //});


            //Task<int> task = Task.Run(() =>
            //{
            //    Console.WriteLine("Started ...");

            //    return 7;
            //});

            //TaskAwaiter<int> awaiter = task.GetAwaiter();

            //awaiter.OnCompleted(() =>
            //{
            //    int result = awaiter.GetResult();
            //    Console.WriteLine("finished ...");
            //    Console.WriteLine(result);
            //});

            ////task.Wait();
            //Console.ReadLine();

            //for (int i = 0;i < 1000;i++)
            //    Console.Write("X");

            //---------------

            //Task<int> task = Task.Run(() =>
            //{
            //    Console.WriteLine("Started ...");
            //    Thread.Sleep(2000); // Simulating some work
            //    return 7;
            //});

            //TaskAwaiter<int> awaiter = task.GetAwaiter();
            //ManualResetEvent waitHandle = new ManualResetEvent(false);

            //awaiter.OnCompleted(() =>
            //{
            //    int result = awaiter.GetResult();
            //    Console.WriteLine("finished ...");
            //    Console.WriteLine(result);

            //    // Simulate blocking behavior for 3 seconds
            //    Thread.Sleep(3000);

            //    // Set the event to signal completion
            //    waitHandle.Set();
            //});

            //// Wait for the callback function to complete
            //waitHandle.WaitOne();

            //Console.WriteLine("Main thread continues after callback completion.");

            //----------------------

            //Task<int> myTask = Task.Run(() =>
            //{
            //    Console.WriteLine("Started ...");

            //    for(int i = 0;i<100;i++)
            //        Console.WriteLine("<task>");

            //    return 10;
            //});

            //int result = await myTask;
            //Console.WriteLine(result);

            //TaskAwaiter<int> awaiter = myTask.GetAwaiter();

            //awaiter.OnCompleted(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Finsihed");
            //});

            //Console.WriteLine(awaiter.GetResult()); // will bolck the main until the calback finishes ...

            //myTask.Wait();

            //Task.WaitAll();

            //Thread.Sleep(1000);

            //-------------------------------------

            //Task myTask = Task.Run(() =>
            //{
            //    Console.WriteLine("starts");
            //    for(int i = 0;i < 100; i++)
            //    {
            //        Console.WriteLine("<Task>");
            //    }
            //});

            //====================================

            //Thread t1 = new Thread(WriteY);
            //Thread t2 = new Thread(WriteY);

            //t1.Start();
            //t2.Start();

            //try
            //{
            //    Task task = Task.Run(GO);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception !");
            //}

            //Task.WaitAll();

            //-----------------------

            //Task<int> result = Task.Run(print);

            ////Thread.Sleep(3000);

            //Console.WriteLine(result.Result);

            //----------------------

            //RunAsync();

            //PrintX();

            //Console.ReadLine();

            //========================================

            #endregion

            #region Sequence

            //string word = "     Omar A ";
            //Console.WriteLine(word.Length);
            //string result = word.MyTrim();
            //Console.WriteLine(result);



            //List<int> nums = new List<int>() {1,3,5,10,12,15,48,-15};

            //List<int> result =  Filter(nums , x => x > 10);

            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerable<int> nums =  Sequence();
            //IEnumerator<int> enumerator = nums.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //List<int> nums = new List<int> { 1, 2 , -4  , 5 , 8 , -2 , -3 , 9};

            //IEnumerable<int> values = nums.MyFilter(x => x > 0)
            //    .MyFilter(x => x % 2 == 0)
            //    .MyFilter(x => x > 5);


            //IEnumerable<int> evenNums = nums.MyFilter(x => x % 2 == 0);

            //foreach (int i in values)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("============================");

            //foreach (int i in evenNums)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region LINQ
            //IEnumerable<Course> courses = SampleData.Courses.MyFilter(c => c.Hours > 2);
            //IEnumerable<int> courses = SampleData.Courses.Choose(c => c.Hours);
            //IEnumerable<string> courses = SampleData.Courses.Choose(c => c.Name);
            //IEnumerable<int> courses = SampleData.Courses.Choose(c => c.Hours);

            //IEnumerable<string> courses =
            //    SampleData.Courses.MyFilter(c => c.Hours > 2)
            //    .Choose(c => c.Name);

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item);
            //}

            //var query = 
            //    SampleData.Courses.Where(c => c.Hours > 2).
            //    Select(c => new {  c.Name , c.Hours });

            //------------------------------------------


            //IEnumerable<string> query =                   // query operaor
            //                    SampleData.Courses
            //                    .Where(c => c.Hours > 2)
            //                    .Select(c => c.Name);

            //var query =                                // query expression
            //    from crs in SampleData.Courses
            //    where crs.Hours > 2
            //    select crs;

            //------------------------------------------


            //var query =                                  // query operaor
            //       SampleData.Courses
            //       .Where(c => c.Hours > 2)
            //       .Select(c => new { Name = c.Name, Hours = c.Hours })
            //       .Take(2);

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //        where crs.Hours > 2
            //        select new { Name = crs.Name, Hours = crs.Hours }).Take(2);

            //------------------------------------------

            //var query =                                  // query operaor
            //  SampleData.Courses
            //  .TakeWhile(c => c.Hours < 4)
            //  .Select(c => new { Name = c.Name, Hours = c.Hours });

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //         select new { Name = crs.Name, Hours = crs.Hours }).TakeWhile(c => c.Hours < 4);


            //------------------------------------------

            // var query =                                  // query operaor
            //SampleData.Courses
            //.SkipWhile(c => c.Hours <= 3)
            //.Select(c => new { Name = c.Name, Hours = c.Hours });

            // var query2 =                                // query expression
            //         (from crs in SampleData.Courses
            //          select new { Name = crs.Name, Hours = crs.Hours }).SkipWhile(c => c.Hours <= 3);

            //------------------------------------------


            //var query =                                  // query operaor
            //         SampleData.Courses
            //         .Where(c => c.Hours <= 3)
            //         .Skip(2)
            //         .Select(c => new { Name = c.Name, Hours = c.Hours });

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //         where crs.Hours <= 3
            //         select new { Name = crs.Name, Hours = crs.Hours }).Skip(2);

            ////------------------------------------------

            //var query =                                  // query operaor
            //         SampleData.Courses
            //         .Where(c => c.Hours <= 3)
            //         .Count();

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //         where crs.Hours <= 3
            //         select new { Name = crs.Name, Hours = crs.Hours }).Count();

            ////foreach (var crs in query)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query);
            //Console.WriteLine("------------------------------");
            ////foreach (var crs in query2)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query2);

            //------------------------------------------

            //var query =                                  // query operaor
            //         SampleData.Courses
            //         //.Where(c => c.Hours <= 3)
            //         .Count(c => c.Hours <= 3);

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //         //where crs.Hours <= 3
            //         select new { Name = crs.Name, Hours = crs.Hours }).Count(c => c.Hours <= 3);

            ////foreach (var crs in query)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query);
            //Console.WriteLine("------------------------------");
            ////foreach (var crs in query2)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query2);


            ////------------------------------------------

            //var query =                                  // query operaor
            //         SampleData.Courses
            //         //.Where(c => c.Hours <= 3)
            //         .Count(c => c.Hours <= 3);      // better in preformance because there is no extra step (where .... )

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //             //where crs.Hours <= 3
            //         select new { Name = crs.Name, Hours = crs.Hours }).Count(c => c.Hours <= 3);

            ////foreach (var crs in query)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query);
            //Console.WriteLine("------------------------------");
            ////foreach (var crs in query2)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query2);


            ////------------------------------------------

            //var query =                                  // query operaor
            //         SampleData.Courses
            //         //.Where(c => c.Hours <= 3)
            //         .Max(c => c.Hours);      // better in preformance because there is no extra step (where .... )

            //var query2 =                                // query expression
            //        (from crs in SampleData.Courses
            //             //where crs.Hours <= 3
            //         select new { Name = crs.Name, Hours = crs.Hours }).Max(c => c.Hours);

            ////foreach (var crs in query)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query);
            //Console.WriteLine("------------------------------");
            ////foreach (var crs in query2)
            ////{
            ////    Console.WriteLine(crs);
            ////}
            //Console.WriteLine(query2);


            ////------------------------------------------

            //var query =                                  // query operaor
            //         sampledata.courses
            //         .where(c => c.hours <= 3)
            //         .orderby(c => c.hours)
            //         .thenbydescending(c => c.name)
            //         .select(c => c);

            //var query2 =                                // query expression
            //        from crs in sampledata.courses
            //        where crs.hours <= 3
            //        orderby crs.hours, crs.name descending
            //        select crs;

            //foreach (var crs in query)
            //{
            //    console.writeline(crs);
            //}
            ////console.writeline(query);
            //console.writeline("------------------------------");
            //foreach (var crs in query2)
            //{
            //    console.writeline(crs);
            //}
            ////console.writeline(query2);

            ////------------------------------------------  
            #endregion

        }

        static string GetCourseName(Course crs)
        {
            return crs.Name;
        }

        static IEnumerable<int> Sequence()
        {
            //List<int> result = new List<int>() {1,2,3,4 };
            //return result;

            yield return 1;

            yield return 2;

            yield return 3;
        }
        static IEnumerable<T> Filter<T>(IEnumerable<T> nums, Predicate<T> predicate)
        {
            List<T> list = new List<T>();
            foreach (T t in nums)
            {
                if (predicate(t))
                {
                    list.Add(t);
                    //yield return t;
                }
            }
            return list;
        }
        static async void RunAsync()
        {
            //Task<int> task = Task.Run(print);
            //TaskAwaiter<int> awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() => Console.WriteLine(awaiter.GetResult())) ;

            int result = await Task.Run(() => print());
            Console.WriteLine(result);
        }
        static bool isFinished = false;
        static object locker = new object();
        static void GO()
        {
            //The remedy is to move the exception handler into the Go method:
            //try
            //{
            throw null;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Found Exception in Go Func using try and catch in GO");
            //}
        }
        static int print()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
            return 100;
        }
        static void PrintX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }
        static void WriteY()
        {
            lock (locker)
            {
                if (!isFinished)
                {
                    Console.WriteLine("Entered the condition ...");
                    isFinished = true;
                }
            }
        }
        static void first() { A(); }
        static void A() { B(); }
        static void B() { C(); }
        static void C()
        {
            StackTrace s = new StackTrace(true);
            Console.WriteLine("Total frames: " + s.FrameCount);
            Console.WriteLine("Current method: " + s.GetFrame(0).GetMethod().Name);
            Console.WriteLine("Calling method: " + s.GetFrame(1).GetMethod().Name);
            Console.WriteLine("Entry method: " + s.GetFrame(s.FrameCount - 1).GetMethod().Name);

            Console.WriteLine("Call Stack:");
            foreach (StackFrame f in s.GetFrames())
                Console.WriteLine(
                " File: " + f.GetFileName() +
                " Line: " + f.GetFileLineNumber() +
                " Col: " + f.GetFileColumnNumber() +
                " Offset: " + f.GetILOffset() +
                " Method: " + f.GetMethod().Name);
        }
    }
    public static class Extensions
    {
        public static IEnumerable<Tout> Choose<Tin, Tout>(this IEnumerable<Tin> input, Func<Tin, Tout> func)
        {
            foreach (var item in input)
            {
                yield return func(item);
            }
        }

        public static IEnumerable<T> MyFilter<T>(this IEnumerable<T> values, Predicate<T> predicate)
        {
            //List<T> list = new List<T>();

            foreach (var item in values)
            {
                if (predicate(item))
                {
                    //list.Add(item);
                    yield return item;
                }
            }
            //return list;
        }

        public static string MyTrim(this string word)
        {
            char[] chars = word.ToCharArray();
            List<char> charList = new List<char>();

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] != ' ')
                {
                    charList.Add(chars[i]);
                }
            }
            string trimmedWord = new string(charList.ToArray());

            return trimmedWord;
        }

    }
}
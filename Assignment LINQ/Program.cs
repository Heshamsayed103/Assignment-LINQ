using assignment_LINQ;

namespace Assignment_LINQ
{
    internal class Program
    {
        static void Main()
        {
            #region Implicitly-Type Local Variables [Var - dynamic]
            //public static var Print(var x)
            //{
            //    return x;
            //}

            //public static dynamic Print(dynamic x)
            //{
            //    return x;
            //}

            #endregion


            static void Main()
            {
                #region Implicitly-Type Local Variables [Var - dynamic]
                //// Implicitly-Type Local Variables [Var - dynamic]

                //// Var

                //var  Data01 = "Ahmed";

                //// Compiler Can Detect DataType Of The Local Variable Based On Initial Value
                //// Must Initilized 
                //// Can not Initialized The Local Varaible With Null
                //// Can not Change DataType Of The Local Variable After Initilized
                //// Can Not Use VAr as Parameter Or Return Type

                //// Data01 = 12; // Invalid


                //// dynamic: Like Var in JS


                ////dynamic Data02 = null;

                //// CLR : Detet The DataType Of THe Local Variable Based On Last Value , At Runtime
                //// Do Not Need To Be Initialized
                //// Can Not Initialized The Local Variable With Null
                //// Can Change DataType Of The Local Variable After Initialization 
                //// Can Use dynamic as Parameter Or Return Type
                //// Be Carefull When Use Dynamic
                //// Like Var in JS Or Object in C#

                ////Console.WriteLine(Data02.GetType().Name);


                ////Data02 = 12;

                ////Console.WriteLine(Data02.GetType().Name);

                ////Data02 =1.4;

                ////Console.WriteLine(Data02.GetType().Name);

                ////Data02 = 1.4f;

                ////Console.WriteLine(Data02.GetType().Name);

                ////Data02 = 1.4m;

                ////Console.WriteLine(Data02.GetType().Name);

                ////Data02 = true;

                ////var x = 12;

                ////var x = () => Console.WriteLine("Hello World ");
                ////var x = delegate () { Console.WriteLine("Hello World "); }; 
                #endregion

                #region Anonymous Type

                //// Anonymous Type 

                ////Employee E01 = new Employee() { Id = 1 ,Name = "Ahmed",Salary = 12000};

                //var E01 = new  { Id = 1 ,Name = "Ahmed",Salary = 12000.0m};
                ////var E02 = new  { Id = 1 ,Name = "Ali",Salary = 15000.0m};
                //var E02 = E01 with { Id =2};  // new feature C# 10.0 


                ////Console.WriteLine(E01.Id);
                ////Console.WriteLine(E01.Name);
                ////Console.WriteLine(E01.Salary);

                ////E01.Id = 12; // invalied : Immuable can not change its value Fter creation

                ////Console.WriteLine(E01.GetType().Name);

                //// the same Anonoymous type as long as:
                //// 1. the same property name 
                //// 2. the same property order

                ////Console.WriteLine(E01.GetHashCode());
                ////Console.WriteLine(E02.GetHashCode());

                ////if (E01.Equals(E02))
                ////{
                ////    Console.WriteLine("E01==E02)");
                ////}
                ////else
                ////{
                ////    Console.WriteLine("E01!=E02)");

                ////} 
                #endregion

                #region Extenssion Methods
                // //Extenssion Methods 

                // int Number = 12345;

                // //var result = IntExtension.Reverse(Number); // class Member Methods 

                //var result= Number.Reverse();  //Extenssion Methods 


                // Console.WriteLine(result); //54321 
                #endregion

                #region  LINQ

                // LINQ : Language Integrated Query
                //      : 40+ Extension Methods (LINQ Operatore ) Against Any Data [Data in Sequence]
                //      : Regardless Data Store
                //      : 13 Category
                //      : LINQ OPerator Exisis in Built - in Class "Enumrable"


                // Sequance : Object From Class Impement Interface "IEnumerable"
                // Locale Squence   : L20, L2XML
                // Remote Sequence  : L2EF

                // Input Squence -> LINQ Operator -> OutPut Squence
                // Input Squence -> LINQ Operator -> One Value
                //               -> LINQ Operator -> Ontput Sequance

                //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};





                ////var result = Enumerable.Where(Numbers, N => N % 2 == 0);


                ////foreach (var item in result)

                ////{
                ////    Console.WriteLine("{ item}"");
                ////} 
                #endregion

                #region LINQ Syntax

                ////// LINQ Syntax

                ////// 1. Fluent Syntax
                ////// use LINQ MEthods

                ////// 1.1. LINQ OPerator as class Member Methods throught Class "Enumerable"

                ////List<int> Number = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
                //// var result = Enumerable.Where(Number, x => x % 2 == 0);
                ////foreach (var item in result)
                ////{
                ////    Console.WriteLine(item);
                ////}


                ////// 1.2 LINQ Operator as => Extension Methods Through Sequance 

                ////List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                ////var result = Number.Where(x => x % 2 == 0);

                ////foreach (var item in result)
                ////{
                ////    Console.WriteLine(item);
                ////}


                //// 2. Query Syntax [Query Expression ] Like SQL Style 

                //// start from
                //// end select , groub by
                //// Query Syntex easier than Fluent (Join , Group By , let , Into)


                // List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //var result = from N in Numbers
                //             where N % 2 == 0   
                //             select N;

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}



                ///*

                // select N
                //from Numbers
                //Where N % 2 = 0

                // */ 
                #endregion

                #region LINQ Execution Ways

                //// LINQ Execution Ways 
                //// 1. Differed Execution Way  : 10 Category
                //// 2. Immediate Execution Way : 3 Category [Elements Operater,Casting Operater , Aggregate Operater]

                ////List<int> Number = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
                ////var result = Number.Where(x => x % 2 == 0); // Differed

                ////Number.AddRange(new int []{11,12,13,14,15});


                ////foreach (var item in result) //here
                ////{
                ////    Console.WriteLine($"{item }");
                ////}



                //List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //var result = Number.Where(x => x % 2 == 0).ToList(); // Immediate

                //Number.AddRange(new int[] { 11, 12, 13, 14, 15 });


                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item}");
                //} 
                #endregion

                //// Setup Data

                //Console.WriteLine(ProductList[0]);
                //Console.WriteLine(CustomerList[0]);

                var result = ProductList.Where(P => P.UnitsInStock == 0);

                foreach (var unit in result)
                {
                    Console.WriteLine(unit);
                }
                Console.WriteLine(ListGenerator.ProductList[0]);
            }
        }
    }
}
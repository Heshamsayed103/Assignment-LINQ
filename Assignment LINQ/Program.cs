namespace Assignment_LINQ
{
    internal class Program
    {
        static void Main()
        {
            //// LINQ: 40+ Extension Methods
            //// LINQ: 13 Category
            ///
            #region 1. Fileteration Operators



            //// 1. Fileteration Operators - Where / OfType

            //// All Proudact Out Of Stock

            ////var result = ProductList.Where(P => P.UnitsInStock == 0);

            //// Query Syntax [Query Expression]


            ////var result = from P in ProductList
            ////                        where P.UnitsInStock == 0
            ////                        select P;   




            ////var result = ProductList.Where(P => P.Category == "Meat/Poultry");


            ////var result = from P in ProductList
            ////             where P.Category == "Meat/Poultry"
            ////             select P;




            ////var result =  ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category== "Meat/Poultry");


            ////var result =  ProductList.Where(P => P.UnitsInStock >0 &&P.Category== "Meat/Poultry");

            ////var result = from P in ProductList
            ////             where P.Category== "Meat/Poultry" && P.UnitsInStock>0
            ////             select P;


            //// Index Where Valid Only In Fluent 
            //// Can Not Be Written Using Query Synatax [Query Expression]
            ////var result= ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            ////var result= ProductList.Where((P, Index) => Index < 5);
            ////var result= ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock>0);
            ////var result= ProductList.Where(P=>P.UnitsInStock>0).Where((P,Index) => Index <5);


            //ArrayList arrylist = new ArrayList() { 1, 2, 3, "Ahmed ", "Ali ", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };
            //var result =arrylist.OfType<float>();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 2. TransFormation Operators
            //  // 2. TransFormation Operators - Select / SelectMany

            //  //var result =  ProductList.Select(P => P.ProductName);


            //  //var result = from P in ProductList
            //  //             select P.ProductName;


            //  //var result = ProductList.Where(P => P.UnitsInStock > 0);
            //  //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //  //                                                                                  .Select(P =>  new { 
            //  //                                                                                      P.ProductName ,
            //  //                                                                                      P.Category,OldPrice = P.UnitPrice ,
            //  //                                                                                      NewPrice = P.UnitPrice - P.UnitPrice * 0.1m
            //  //                                                                                  });


            //  //var result = from P in ProductList
            //  //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //  //             select new
            //  //             {

            //  //                 P.ProductName,
            //  //                 P.Category,
            //  //                 OldPrice = P.UnitPrice,
            //  //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1m

            //  //             };


            //  //var result = CustomerList.Select(C => C.CustomerName);
            //  //var result = CustomerList.Select(C => C.Orders); // if one of Proparty is Sequance
            //  //var result = CustomerList.SelectMany(C => C.Orders); // if one of Proparty is Sequance

            //  //var result = from C in  CustomerList
            //  //             from O in C.Orders
            //  //             select O;  


            //  // Indexed Select Valid Only In Fluent Synteax
            //  // Can Not Be Written Using Query Syntax [Query Expression ]
            ////var result =  ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);



            //  foreach (var item in result)
            //  {
            //      Console.WriteLine(item);
            //  } 
            #endregion

            #region 3. Ordering Operators
            //// 3. Ordering Operators

            //// Sorting 

            ////var result = ProductList.OrderBy(P => P.UnitPrice);
            ////var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new {P.ProductName,P.UnitPrice});
            ////var result = ProductList.OrderBy(P => P.UnitsInStock)
            ////                                                                     .Select(P => new 
            ////                                                                     {
            ////                                                                         P.ProductName,
            ////                                                                         P.UnitPrice,
            ////                                                                         P.UnitsInStock
            ////                                                                     });

            ////var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            ////                                                                     .Select(P => new
            ////                                                                     {
            ////                                                                         P.ProductName,
            ////                                                                         P.UnitPrice,
            ////                                                                         P.UnitsInStock
            ////                                                                     });

            //////var result = ProductList.OrderBy(P => P.UnitsInStock).ThenBy(P => P.UnitPrice)
            //////                                                                     .Select(P => new
            //////                                                                     {
            //////                                                                         P.ProductName,
            //////                                                                         P.UnitPrice,
            //////                                                                         P.UnitsInStock
            //////                                                                     });

            ////var result = ProductList.Where(P => P.Category=="Seafood") 
            ////                                                                     .OrderBy(P => P.UnitsInStock).ThenBy(P => P.UnitPrice)
            ////                                                                     .Select(P => new
            ////                                                                     {
            ////                                                                         P.ProductName,
            ////                                                                         P.UnitPrice,
            ////                                                                         P.UnitsInStock
            ////                                                                     });


            ////var result = from P in ProductList
            ////             orderby P.UnitPrice descending
            ////             select new
            ////             {
            ////                 P.ProductName,
            ////                 P.UnitPrice,
            ////                 P.UnitsInStock
            ////             };


            //var result = ProductList.Reverse<Product>();





            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////foreach (var item in ProductList)
            ////{
            ////    Console.WriteLine(item);

            ////} 
            #endregion

            #region 4. Elements Operators
            // // 4. Elements Operators - Immediate Execution

            // ProductList = new List<Product>();



            // //var result = ProductList.First(); // May Throw Exception
            // //var result = ProductList.Last(); // May Throw Exception




            // //var result = ProductList.First(P => P.UnitsInStock == 0); // May Throw Exception
            // //var result = ProductList.Last(P => P.UnitsInStock == 0); // May Throw Exception



            // //var result = ProductList.FirstOrDefault();
            // //var result = ProductList.FirstOrDefault( new Product { ProductName = "Defalut Product "});
            // //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 10000);
            // //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 10000, new Product { ProductName = "Defalut Product " });



            // //var result = ProductList.LastOrDefault();
            // //var result = ProductList.LastOrDefault(new Product { ProductName = "Defalut Product " });
            // //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 0);
            // //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 10000, new Product { ProductName = "Defalut Product " });



            // //var result = ProductList.ElementAt(0); // May Throw Exception

            // //var result = ProductList.ElementAtOrDefault(1); // May Throw Exception

            // //var result = ProductList.Single();  // May Throw Exception



            // //var result = ProductList.Single(P => P.UnitsInStock == 0);  // May Throw Exception



            // //var result = ProductList.SingleOrDefault();  // May Throw Exception


            // //var result = ProductList.SingleOrDefault(new Product { ProductName = "Defalut Product " }); 


            // //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);  // May Throw Exception



            // //var result = ProductList.SingleOrDefault( P => P.UnitsInStock == 0 , new Product { ProductName = "Defalut Product " }); 


            ////var result = ProductList.DefaultIfEmpty();
            ////var result = ProductList.DefaultIfEmpty(new Product { ProductName = "Defalut Product " });


            // foreach (Product item in result)
            // {
            //     Console.WriteLine(item);
            // }

            // //Console.WriteLine(result?.ProductName ?? "NA");

            #endregion

            #region 5. Aggregate Operators
            // // 5. Aggregate Operators - Immediate Exectution 

            // // Count - Sum - Max - Min - Avg 

            // //var result =  ProductList.Count(); // 77
            // //var result =  ProductList.Count; // 77

            // //var result = ProductList.Count(P => P.UnitsInStock == 0); // 5

            // //var result = ProductList.Where(P => P.UnitsInStock == 0).Count();


            // // Sum 

            // //var result = ProductList.Sum(P => P.UnitPrice); // 2222.7100
            // //var result = ProductList.Sum(P => P.UnitsInStock); // 2222.7100


            // // Aug 

            // //var result = ProductList.Average(P => P.UnitPrice); // 28.866363636363636363636363636


            // // Max 

            // //var result = ProductList.Max(); // 263.50 Based on Icompareable
            // //var result = ProductList.Max(new ProductComparerUnitInstock()); // 125 Based on Icompareable
            // //var result = ProductList.Max( P => P.UnitPrice );
            // //var result = ProductList.Max( P => P.UnitsInStock );


            // //var MaxPrice = ProductList.Max( P => P.UnitPrice );

            // //var result = ProductList.Where(P => P.UnitPrice == MaxPrice);


            // //var result = ProductList.MaxBy(P => P.UnitPrice); // Product

            // // Min

            // //var result = ProductList.Min();
            // //var result = ProductList.Min(new ProductComparerUnitInstock());
            // //var result = ProductList.Min(new ProductComparerNameLength());

            // //var result =  ProductList.Min(P => P.UnitPrice); // 2.5000

            // //var result =  ProductList.MinBy(P => P.ProductName,new ProductComparerNameLength01());


            // // Aggregate

            // List<string> Names = new List<string>() { "Ahmed","Ali","Omar","Osama"};

            //var result = Names.Aggregate((S01,S02)=>$"{S01}{S02}");


            // Console.WriteLine(result); 
            #endregion

            #region Casting Operators


            //// Casting Operators


            ////List<Product> list =(List<Product>) ProductList.Where(P => P.UnitsInStock == 0); // invalied
            ////List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            ////Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            ////Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();






            //foreach (Product item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Generation Operators
            //// 7. Generation Operators
            ////the Only Way to call This Methods as --> class Member methods throught "Enumerable" Class

            //// Range , Empty , Repeat

            ////var result = Enumerable.Range(1, 100);


            ////var result = Enumerable.Empty<Product>().ToList();

            ////result.Add(new Product() { ProductName = "Product01" });
            ////result.Add(new Product() { ProductName = "Product02" });


            ////var result = Enumerable.Repeat(ProductList[0], 3);
            ////var result = Enumerable.Repeat(ProductList[1], 30);




            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Set Operators
            //// 8. Set Operators - Union Family
            //// Union - Union All - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100); // 1 ....100
            //var Seq02 = Enumerable.Range(50, 100); // 50 ....100


            ////var result =  Seq01.Union(Seq02); // Like Union in SQL Without Dublication
            ////var result = Seq01.Concat(Seq02); // Like Union in SQL With Dublication


            ////result =  result.Distinct(); // Remove Dublication

            ////var result = Seq01.Intersect(Seq02);
            ////var result = Seq01.Except(Seq02);



            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //} 
            #endregion

            #region 9. Quantifiers Operators
            //// 9. Quantifiers Operators - Return Boolean

            //// Any - All - SequanceEqual - Contains


            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);


            //// Any() --> Return True If There Are at Least One Element [in Sequance or Match The Condition]

            ////var result = Seq01.Any(N => N %2 == 0);


            //// ProductList = new List<Product>();




            ////var result = ProductList.Any(P => P.UnitsInStock == 0);


            //// All() --> Return True If All Element in the Sequance Match the Condition or is Empty

            ////var result = ProductList.All(P => P.UnitsInStock == 0);
            ////var result = ProductList.All(P => P.UnitPrice> 0);


            //// SequanceEqual() 

            ////var result = Seq01.SequenceEqual(Seq02);

            ////var result = Seq02.Contains(1);

            ////ProductList.Contains();


            //Console.WriteLine(result);

            #endregion

            #region 10. Zipping Operators
            //  // 10. Zipping Operators
            //  // Zip


            // List<string> words = new List<string>() { "ten","twenty","thirty","fourty"};

            // List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            ////var result = words.Zip(numbers,(W,N) => $"{N} --> {W}");
            //var result = words.Zip(numbers,(W,N) => new {Number = N , word = W});

            // foreach (int item in numbers)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region Grouping Operators


            //// Grouping Operators

            ////var result =  ProductList.GroupBy(P => P.Category);


            ////  result = from p in ProductList
            ////           group p by p.Category;



            ////  foreach (var Category in result)
            ////  {
            ////      Console.WriteLine(Category.Key);
            ////      foreach (var product in Category)
            ////      {
            ////          Console.WriteLine($".......{product}");
            ////      }
            ////  }


            ////var result = from P in ProductList
            ////             where P.UnitsInStock > 0
            ////             group P by P.Category
            ////             into Category
            ////             where Category.Count() > 5
            ////             select new {CategoryName = Category.Key, CountCategory = Category.Count()};


            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                                            .GroupBy(P => P.Category)
            //                                            .Where(C => C.Count() > 5)
            //                                            .Select(C => new { CategoryName = C.Key, CountCategory = C.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            ////foreach (var Category in result)
            ////{
            ////    Console.WriteLine(Category.Key);
            ////    foreach (var product in Category)
            ////    {
            ////        Console.WriteLine($".......{product}");
            ////    }
            ////} 
            #endregion

            #region Partioning Operators
            //// Partioning Operators - Take , TakeLast , Skip, SkipLast , TakeWhile , SkipWhile 

            ////var result = ProductList.Where(P =>P.UnitsInStock ==0 ).Take(3);
            ////var result = ProductList.TakeLast(5);

            ////var result = ProductList.Skip(5).Take(5);

            ////var result = ProductList.SkipLast(5);


            ////int[] Numbers = {9,6,4,1,2,3,4,5};
            //////var result = Numbers.TakeWhile((N) =>N % 3 == 0);
            ////var result = Numbers.SkipWhile((N) =>N % 3 == 0);


            //int[] Numbers = { 9, 6, 4, 1, 2, 3, 4, 5 };
            ////var result = Numbers.TakeWhile((N, I) => N > I);
            //var result = Numbers.SkipWhile((N, I) => N > I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region let / into

            // // let / into 
            // // Query Syntax

            // // aeoiuAEOIU

            // List<string> Names = new List<string>() { "Ahmed","Ali","omar","Aya","Mona","Fares"};


            // //var result = from Name in Names
            // //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            // //             into NoVolNames
            // //             // into : Restart Query 
            // //             where NoVolNames.Length > 3
            // //             select NoVolNames;


            // var result = from Name in Names
            //              let NoVolNames = Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)

            //              where NoVolNames.Length > 3
            //              select NoVolNames;



            // foreach (var item in Names)
            // {
            //     Console.WriteLine(item);
            // }


            ////var result = Regex.Replace("Ahmed", "[aeoiuAEOIU]",string.Empty)

            ////     Console.WriteLine(result); 
            #endregion

        }
    }
}
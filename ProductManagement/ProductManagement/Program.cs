using System;
using System.Collections.Generic;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system!");
            //UC1-Adding 25 Default value in the list
            Console.WriteLine("\nUC1-Listing the products with properties:-----------------");
            List<ProductReview> productReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=false},
                new ProductReview(){ProductID=6,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=7,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=8,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=9,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=10,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=11,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=12,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=13,UserID=18,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=10,Rating=2,Review="Bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=19,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=16,UserID=10,Rating=3.5,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=10,Rating=3.2,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=15,Rating=3.5,Review="nice",isLike=true},
                new ProductReview(){ProductID=19,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=20,UserID=13,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=21,UserID=23,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=22,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=23,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=24,UserID=10,Rating=2,Review="Bad",isLike=true},
                new ProductReview(){ProductID=25,UserID=2,Rating=4,Review="Good",isLike=true},
            };
            //Iterating the 25 products using foreach loop
            foreach (var list in productReview)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
            //UC2_printing top 3 products
            Console.WriteLine("\nUC2- Top 3 Records:------------------");
            Management management = new Management();
            management.TopRecords(productReview);

            //UC3_Retriving data Using linq
            Console.WriteLine("\nUC3_Retriving data greater than 3 ratings:-----------------------------");
            management.SelectedRecords(productReview);

            //UC4_Retriving count of review for each product
            Console.WriteLine("\nUC4_retriving count of review each product:------------------------------");
            management.RetrieveCountOfRecords(productReview);

            Console.WriteLine("\nUC5-Retriving ProductsId and review from list:------------------------------");
            management.RetrieveOnlyProductIdAndReview(productReview);

            Console.WriteLine("\nUC6-Skiping first five records from list:-----------------------");
            management.SkipTopFiveRecords(productReview);

            Console.WriteLine("\nUC7-Retriving productId and revies using Linq:-------------------");
            management.SelectIdAndReview(productReview);
        }
    }
}

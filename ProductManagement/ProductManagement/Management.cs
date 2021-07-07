using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace ProductManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> review)
        {

            var recordedData = (from productReviews in review
                                    //This is giving Records of top 3 records in descending order
                                orderby productReviews.Rating descending 
                                select productReviews).Take(3);
            //Iterating the Records to print top 3 products
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
        /// <summary>
        /// In this UC we retriving all records whose ratings greater than 3 and product ID 1 or 4 or 9 using Linq
        /// </summary>
        /// <param name="review"></param>
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               //Retriving data any one on 1 or 4 or 9 here using or operator
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               //must be greater than 3
                               && productReviews.Rating > 3
                               select productReviews;
            //Printing the Products
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
    }
}

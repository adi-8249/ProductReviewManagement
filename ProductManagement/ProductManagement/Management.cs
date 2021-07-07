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
    }
}

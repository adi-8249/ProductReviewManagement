using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace ProductManagement
{
    public class Management
    {
        /// <summary>
        /// UC2-Listing the products by order with descending as per ratings
        /// </summary>
        /// <param name="review"></param>
        public void TopRecords(List<ProductReview> review)
        {

            var recordedData = (from productReviews in review
                                    //This is giving Records of top 3 records in descending order
                                orderby productReviews.Rating descending 
                                select productReviews).Take(3);//here it will take only 3 ratings
            //Iterating the Records to print top 3 products
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
        /// <summary>
        /// UC3- we retriving all the records whose ratings greater than 3 and product ID 1 or 4 or 9 using Linq
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
        /// <summary>
        ///UC4- Retriving count of the review available for each product
        /// </summary>
        /// <param name="review"></param>
        public void RetrieveCountOfRecords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "==>" + list.Count);
            }
        }
        /// <summary>
        /// UC5-Retriving only productId and reviews 
        /// </summary>
        /// <param name="review"></param>
        public void RetrieveOnlyProductIdAndReview(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               select new { productReviews.ProductID, productReviews.Review };
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "Review:-" + list.Review);
            }
        }
        /// <summary>
        /// UC6-Skiping top five records and displaying other records from list 
        /// </summary>
        /// <param name="review"></param>
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                select productReviews).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
        /// <summary>
        /// Retriving product id and revies using Linq
        /// </summary>
        /// <param name="review"></param>
        public void SelectIdAndReview(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                select "ProductId :" + productReviews.ProductID + " Review :" + productReviews.Review);
            foreach (var item in recordedData)
            {
                Console.WriteLine(item);
            }
        }
    }
}

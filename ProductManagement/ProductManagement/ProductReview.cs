using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement
{
    public class ProductReview
    {
        /// <summary>
        /// Using get set properties getting and setting the values
        /// </summary>
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}

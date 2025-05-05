using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.BlogDto
{
   public class GetBlogById
    {
        public int blogID { get; set; }

        public int AuthorID { get; set; }
        public string coverImageUrl { get; set; }
        public string Title { get; set; }
        public DateTime createdDate { get; set; }
        public int categoryID { get; set; }
        public string Description { get; set; }
      
    }
}

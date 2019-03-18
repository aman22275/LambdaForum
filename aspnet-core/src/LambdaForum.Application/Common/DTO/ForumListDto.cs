using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.DTO
{
    //DTO to list all the forums , eg on index page
    public class ForumListDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
    }
}

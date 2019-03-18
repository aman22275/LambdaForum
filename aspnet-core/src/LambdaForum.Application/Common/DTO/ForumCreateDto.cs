using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.DTO
{
    //DTO to create the new forums
    public class ForumCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "Bookmark")]
    public class Bookmark
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "Title")]
        public string Title { get; set; }

        [Column(Name = "HadithId")]
        public int HadithId { get; set; }

        [Column(Name = "PageNo")]
        public int PageNo { get; set; }

        [Column(Name = "ChapterNo")]
        public int ChapterNo { get; set; }

        [Column(Name = "HadithNo")]
        public int HadithNo { get; set; }


    }
}

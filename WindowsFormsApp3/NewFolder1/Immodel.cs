using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.NewFolder1
{
    class Immodel
    { 
        MDAEntities2 db = new MDAEntities2();
        MovieImages MovieImages = new MovieImages();

        //public  showdataMovieImageList()
        //{
        //    var p = from r in db.電影圖片MovieIImagesList
        //            select new { r.電影圖片編號MI_ID, r.電影編號Movie_ID, r.圖片編號Image_ID };
        //    var list2 = p.ToList();
        //    return list2;
        //}
    }
}

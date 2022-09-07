using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class PhotoBookTest
    {
        public static void Main3()
        {
           PhotoBook myAlbums1 = new PhotoBook();
            Console.WriteLine(myAlbums1.GetNumberPages());
            PhotoBook myAlbums2 = new PhotoBook(24);
            Console.WriteLine(myAlbums2.GetNumberPages());
            SuperPhotoBook myBigAlbums1 = new SuperPhotoBook();
            Console.WriteLine(myBigAlbums1.GetNumberPages());
     }
    }
    public class PhotoBook
    {
        protected int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook()
        {
            numPages = 64;
        }
    }

}

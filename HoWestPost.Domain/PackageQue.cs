using System;
using System.Collections.Generic;
using System.Text;

namespace HoWestPost.Domain
{
    public class PackageQue
    {
        public int id { get; set; }
        public Package package { get; set; }

        public PackageQue(int Id, Package Package) 
        {
            id = Id;
            package = Package;
        }
    }
}

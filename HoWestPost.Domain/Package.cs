using System;
using System.Collections.Generic;
using System.Text;

namespace HoWestPost.Domain
{
    public class Package
    {
        public enum PackageType {Mini, Standaard, Maxi }

        public int id { get; set; }
        public int type { get; set; }
        public int reistijd { get; set; }
        public int prior { get; set; }

        public Package(int Id, int Type, int Reistijd, int Prior) 
        {
            id = Id;
            type = Type;
            reistijd = Reistijd;
            prior = Prior;

        }

        public override string ToString()
        {
            return $"{(PackageType)type} pakket";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HoWestPost.Domain
{
    public class Delivery
    {
        public List<Package> Packages = new List<Package>();
        int aantalPackages = 0;

        public Delivery()
        { 
            
        }

        public void AddPackage(int Type, int Reistijd, int Prior )
        {
            int Id = aantalPackages + 1;

            if (Prior == 0)
            {
                Package nieuw = new Package(Id, Type, Reistijd, Prior);
                aantalPackages += 1;
                Packages.Add(nieuw);

            }
            else if (Prior == 1) {
                Package nieuw = new Package(Id, Type, Reistijd, Prior);
                aantalPackages += 1;
                Packages.Insert(0, nieuw);
            }
        }
    }
}

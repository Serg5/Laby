using System;
using System.Collections.Generic;
using System.Text;

namespace Torg.DomainObjects
{
    public class Torg : DomainObject
    {
        public string Name { get; set; }

        public string ObjType { get; set; }

        public Location Location { get; set; }

        public Ocrug Ocrug { get; set; }
    }
}

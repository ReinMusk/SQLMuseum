using SQLMuseum.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMuseum
{
    public class Bd_connection
    {
        public static MuseumEntities connection = new MuseumEntities();
    }
}

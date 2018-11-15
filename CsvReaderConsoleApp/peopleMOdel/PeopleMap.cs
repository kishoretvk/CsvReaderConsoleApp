using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvReaderConsoleApp.peopleMOdel
{
    public class PeopleMap : ClassMap<People>
    {
        public PeopleMap()  : base()
        {
            // Multiple possible names
            Map(m => m.name).Name("name", "Name", "name ");
            Map(m => m.first).Name("first", "first ", " first ");
            Map(m => m.last).Name("last", "last ", " last ");

            Map(m => m.middle).Name("middle", "middle ", " middle ");
            Map(m => m.email).Name("email", "email ", " email ");
            Map(m => m.phone).Name("phone", "phone ", " phone ");

            Map(m => m.fax).Name("fax", "fax  ", "  fax  ");
            Map(m => m.title).Name("title", " title ", "  title  ");
            
        }
    }
} 

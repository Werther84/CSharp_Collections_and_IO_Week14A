﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollections
{
    class LookupCollections
    {
        static void Main(string[] args)
        {
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            list["Estado Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            Console.WriteLine(list["españa"]);
            Console.WriteLine(list["CANADÁ"]);
        }
    }
}

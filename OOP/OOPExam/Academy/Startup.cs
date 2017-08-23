﻿using Academy.Core;
using Academy.Models;
using System;
using System.Collections.Generic;

namespace Academy
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // Singleton design pattern
            // Ensures that there is only one instance of Engine in existance
            var engine = Engine.Instance;
            engine.Start();


        }



    }
}


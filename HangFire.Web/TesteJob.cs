﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFire.Web
{
    public class TesteJob
    {
        [System.Diagnostics.DebuggerStepThrough]
        public void Run()
        {
            System.Threading.Thread.Sleep(1000 * 15);
            throw new Exception();
        }
    }
}

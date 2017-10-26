﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    public class Invoker
    {
        public void Execute(Command command)
        {
            command.Execute();
        }
    }
}

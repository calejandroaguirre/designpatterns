﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    public class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user
            Console.ReadKey();
        }
    }
}

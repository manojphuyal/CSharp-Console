﻿using System;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample.ConstructorExample
{
    class ProgramUserDefineConstructor
    {
         ProgramUserDefineConstructor()
        {
            Console.WriteLine("Hello from Constructor");
        }
        static void MainProgramUserDefineConstructor()
        {
            ProgramUserDefineConstructor obj = new ProgramUserDefineConstructor();
            //Class_Object My_Object_Name = new Class_Object[or new it is initiliazation of constructor]
            Console.ReadLine();
        }
    }
}

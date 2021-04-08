﻿using System;
namespace CustomInterfaces

{
    public class Circle :Shape

    {
        public Circle()
        {
        }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle ", PetName);
        }


    }
}

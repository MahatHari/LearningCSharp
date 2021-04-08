using System;
namespace CustomInterfaces
{
    public abstract class Shape
    {
        // properties
        public string PetName { get; set; }
        

        // Constructor
        protected Shape(string name= "NoName")
        {
            PetName = name;
        }

        // Methods
        // Force all chile classes to define how to be rendered
        public abstract void Draw();
        
       
    }
}

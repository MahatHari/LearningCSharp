using System;
namespace CustomInterfaces
{
    public interface IPointy
    {
        //Implicitly public and abstract
        //byte GetNumberOfPoints();


        // a read-write property in an interface would look like:
        //string PropName{get; set;}

        // while a write-only property in an interface would be:
        byte Points { get; }
    }
}

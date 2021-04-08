using System;
namespace CustomInterfaces
{
    public abstract class CloneableType
    {
        // "only derived types can support this
        // ploymorphic interface." clases in other
        // hierarchies have no access to this abstract
        // member
        public abstract object Clone(); 
        public CloneableType()
        {
        }
    }
}

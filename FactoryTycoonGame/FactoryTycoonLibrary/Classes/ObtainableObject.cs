using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public abstract class ObtainableObject
    {
        protected readonly int _id;
        protected readonly string _name;
        protected readonly string _description;

        protected ObtainableObject(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public int ID
        {
            get { return _id; }
        }

        public string Name 
        { 
            get { return _name; } 
        }

        public string Description 
        { 
            get { return _description; } 
        }
    }
}

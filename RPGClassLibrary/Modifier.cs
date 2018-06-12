using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Modifier
    {
        public string ModifierName { get; set; }            //how do we call Mod
        public double ModifierValue { get; set; }           // Value that Mod has
        public  object Source { get; set; }                 // If we want to know where the Mod came from
        public Modifier(double _modvalue, string _modname, object _source)
        {
            ModifierName = _modname;
            ModifierValue = _modvalue;
            Source = _source;
        }

        // Constructor sets default source is we don't need it
        public Modifier(double _modvalue, string _modname) : this(_modvalue, _modname,  null) { }

    }
}

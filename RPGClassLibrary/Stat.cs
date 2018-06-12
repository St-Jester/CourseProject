using System;
using System.Collections.Generic;

namespace RPGClassLibrary
{
    public class Stat
    {
        
        private double _value;                              //modifier value
		
        private bool hasChanged = true;                     //is the modifier changed
        public double BaseValue { get; private set; }       //base value is maxvalue 
        public List<Modifier> AllModifiers { get; set; }    //list of modifiers of current stat
		
		
        public double CurrentValue
        {
            get
            {
                if (hasChanged)
                {
                    _value = CalculateFinalValue();
                    hasChanged = false;
                }
                return _value;
            }
            set => _value = value;
        }

		public Stat(double _basevalue)
		{
			BaseValue = _basevalue;

			AllModifiers = new List<Modifier>();
		}

		//gets value with account of Mods
		private double CalculateFinalValue()                
        {
            double finalValue = BaseValue;

            for (int i = 0; i < AllModifiers.Count; i++)
            {
                finalValue += AllModifiers[i].ModifierValue;
            }
            // Rounding gets around dumb float calculation errors
            return Math.Round(finalValue, 4);
        }

        public void AddModifier(Modifier b)
        {
            if (b != null)
            {
                foreach (var item in AllModifiers)
                {
                    if (item.ModifierName == b.ModifierName)
                    {
                        return;
                    }
                }
                hasChanged = true;
                AllModifiers.Add(b);
            }
        }
        
        public void RemoveModifier(Modifier b)
        {
            if (b != null)
            {
                AllModifiers.Remove(b);
                hasChanged = true;
            }
        }

        // clear all Mods from one object
        public bool RemoveAllModifiersFromSource(object source)
        {
            bool didRemove = false;

            for (int i = AllModifiers.Count - 1; i >= 0; i--)
            {
                if (AllModifiers[i].Source == source)
                {
                    hasChanged = true;
                    didRemove = true;
                    AllModifiers.RemoveAt(i);
                }
            }
            return didRemove;
        }

        //public static Stat operator +(Stat s1, Stat s2)
        //{
        //    Stat s =  new Stat(s1.BaseValue)
        //    {
        //        CurrentValue = s2.CurrentValue +s1.CurrentValue
        //    };
        //    return  s;
        //}
        //public static Stat operator -(Stat s1, Stat s2)
        //{
        //    Stat s = new Stat(s1.BaseValue)
        //    {
        //        CurrentValue = s2.CurrentValue - s1.CurrentValue
        //    };
        //    return s;
        //}
        //public static Stat operator +(Stat s1, double d)
        //{
        //    Stat s = new Stat(s1.BaseValue)
        //    {
        //        CurrentValue = s1.CurrentValue + d
        //    };
        //    return s;
        //}

        //public static Stat operator -(Stat s1, double d)
        //{
        //    Stat s = new Stat(s1.BaseValue)
        //    {
        //        CurrentValue = s1.CurrentValue - d
        //    };
        //    return s;
        //}

        public static bool operator >(Stat s1, Stat s2) => s1.CurrentValue > s2.CurrentValue;
        public static bool operator <(Stat s1, Stat s2) => s1.CurrentValue < s2.CurrentValue;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Equipment
    {
		public EquipmentSlot equipmentSlot = new EquipmentSlot();
		public string EquipmentName { get; set; }

		public Modifier HPModifier { get; set; }
        public Modifier DamageModifier { get; set; }

        public Equipment(string _eqname, int _eqslot, 
			double _hpValue = 0, double _damageValue = 0)
        {
            HPModifier = new Modifier(_hpValue, EquipmentName, this);
            DamageModifier = new Modifier(_damageValue, EquipmentName, this);
            equipmentSlot = (EquipmentSlot)_eqslot;
        }
    }
}

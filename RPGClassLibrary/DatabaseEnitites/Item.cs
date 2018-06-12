using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{

	public enum EquipmentSlot
	{
		Torso,
		Arms,
		Legs,
		Weapon
	}

	public class Item
    {
		public int Id { get; set; }
		public string ItemName { get; set; }
		public EquipmentSlot ItemType { get; set; }			//from 1-4 applied by enum
		public double ItemBonus { get; set; }		//coeff to multiply itemType with
    }
}

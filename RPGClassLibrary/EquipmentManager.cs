using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class EquipmentManager
    {
        Equipment[] currentEquipment;
        // Callback for when an item is equipped/unequipped
        public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
        public OnEquipmentChanged onEquipmentChanged;


        public EquipmentManager()
        {
            int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
            currentEquipment = new Equipment[numSlots];

        }

        public void Equip(Equipment newItem)
        {
            int slotIndex = (int)newItem.equipmentSlot;

            Equipment oldItem = Unequip(slotIndex);

            // Insert the item into the slot
            currentEquipment[slotIndex] = newItem;


            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(newItem, oldItem);
            }
        }

        public Equipment Unequip(int slotIndex)
        {
            Equipment oldItem = null;

            if (currentEquipment[slotIndex] != null)
            {
                oldItem = currentEquipment[slotIndex];

                // Remove the item from the equipment array
                currentEquipment[slotIndex] = null;

                // Equipment has been removed so we trigger the callback
                if (onEquipmentChanged != null)
                {
                    onEquipmentChanged.Invoke(null, oldItem);
                }
            }
            return oldItem;
        }
    }
}

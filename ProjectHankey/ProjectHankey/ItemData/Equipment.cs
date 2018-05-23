using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHankey.ItemData
{
	[Serializable]
	class Equipment : Item
	{
		[Flags]
		public enum EquipmentType
		{
			//메인분류
			Weapon = 0x100,
			SubWeapon = 0x200,
			Armor = 0x400,

			//서브분류
			Sword = 0x101
		}

		[NonSerialized]
		protected static System.Runtime.Serialization.Formatters.Binary.BinaryFormatter s_binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

		protected CharacterData.Character.ClassType m_isUsableBy;
		protected EquipmentType m_equipmentType;

		protected int m_adBasic, m_adSpecial, m_adCheck;
		protected int m_amBasic, m_amSpecial, m_dmReduction, m_dmRecductionSpecial;
		protected int m_mvBasic, m_mvSpecial, m_mvMinimum, m_mvMinimumSpecial;

		protected int m_attackRange, m_checkRange, m_limitRange, m_AttackTimes;
		protected int m_defenceRange, m_defenceTimes;

		protected int m_upgrade, m_upgradeMax;

		public Equipment()
		{

		}



		protected void SerializedSave(Int64 ItemUID)
		{
			using (System.IO.FileStream fileStream = new System.IO.FileStream(ItemUID.ToString() + ".equip",
				System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None))
			{
				Equipment.s_binaryFormatter.Serialize(fileStream, this);
			}
		}

		public static Equipment Deserialize(Int64 ItemUID)
		{
			if(System.IO.File.Exists(ItemUID.ToString() + ".equip"))
			{
				using (System.IO.FileStream fileStream = new System.IO.FileStream(ItemUID.ToString() + ".equip",
					System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None))
				{
					return Equipment.s_binaryFormatter.Deserialize(fileStream) as Equipment;
				}
			}
			else
			{
				Console.WriteLine("That ItemUID does not exist!");
				return null;
			}
		}
	}
}
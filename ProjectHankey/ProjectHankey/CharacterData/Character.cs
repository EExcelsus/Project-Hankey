using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHankey.CharacterData
{
	class Character
	{
		[Flags]
		public enum ClassType
		{
			//직업 대분류
			WarriorClass = 0x0100,
			ArcherClass = 0x0200,
			MageClass = 0x0400,
			PriestClass = 0x0800,
			RogueClass = 0x1000,

			//직업 상세분류, 처음 두 자리수는 대분류의 것을 사용하도록 함
			Warrior = 0x0101
		};

		[Flags]
		public enum Status
		{
			//현재 상태
			Alive = 0x100,
			Injured = 0x200,
			HeavyInjured = 0x400,
			Dead = 0x800,

			//CC기 상태, 첫째 자릿수 신경안써도 됨
			Stunned = 0x1

		}

		protected ClassType m_classType;
		protected String m_className;
		protected int m_level;
		protected int m_upgradeLevel;
		protected Int64 m_exp;
		protected int m_favor;

		protected int m_hpMax, m_hpCurrent;
		protected int m_spMax, m_spCurrent;

		protected int m_adBasic, m_adEquipment, m_adSpecial;
		protected int m_amBasic, m_amEquipment, m_amSpecial;
		protected int m_mvBasic, m_mvEquipment, m_mvSpecial;

		protected Status m_currentStatus;
		//TODO: 버프/디버프 관련 시스템

		protected int m_hpRegen, m_spRegen;
		public int MovementPoint()
		{
			return 0;
		}

		protected ItemData.Equipment m_weapon;
		protected ItemData.Equipment m_subWeapon;
		protected ItemData.Equipment m_armor;
		protected ItemData.Skill[] m_skill;
		protected ItemData.Consumable m_Consumable;

		protected int[] m_currentPosition;

		protected int m_stunPoint, m_stunResistance;

	}
}

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
		public enum ClassType {
			//직업 대분류
			WarriorClass = 0x000,
			ArcherClass = 0x100,
			MageClass = 0x200,
			PriestClass = 0x400,
			RogueClass = 0x800,

			//직업 상세분류, 첫 자리수는 대분류의 것을 사용하도록 함
			Warrior = 0x001
		};


	}
}

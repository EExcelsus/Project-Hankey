using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHankey
{
	class Weapon : Equipment
	{
		protected int m_adBasic, m_adSpecial, m_adCheck;
		protected int m_amBasic, m_amSpecial, m_dmReduction, m_dmRecductionSpecial;
		protected int m_mvBasic, m_mvSpecial, m_mvMinimum, m_mvMinimumSpecial;

		protected int m_attackRange, m_checkRange, m_limitRange, m_AttackTimes;
		protected int m_defenceRange, m_defenceTimes;

		protected int m_upgrade, m_upgradeMax;
		//TODO: 업글 상세 관련

		//TODO: 추가 효과 관련
	}
}

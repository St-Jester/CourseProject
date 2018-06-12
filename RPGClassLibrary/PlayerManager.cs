using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class PlayerManager
    {
		//SINGLETON
		public static PlayerManager instance;

		public string PlayerName { get; set; }
		public Stat HP { get; set; }
		public Stat Stamina { get; set; }

		public int CurrentLevel { get; set; }
		public double CurrentXP { get; set; }
		private double levelingcoeff = 1.0;		//how much XpPerLev changes afterlvlvup
		private double XpPerLevel = 100;        //base Xp needed

		public QuestState playerQuesting = QuestState.NotTaken;

		public PlayerManager(string playerName, Stat hP, Stat stamina, int currentLevel, double currentXP, double money)
		{
			if (instance != null)
			{
				return;
			}
			instance = this;

			PlayerName = playerName;
			HP = hP;
			Stamina = stamina;
			CurrentLevel = currentLevel;
			CurrentXP = currentXP;
			Money = money;
		}

		public double Money { get; set; }


		//Level magement
		
		public void LevelUp()
		{
			CurrentLevel += (int)(CurrentXP / XpPerLevel);
			CurrentXP = CurrentXP % XpPerLevel;
		}

		public bool IsLvlUp()
		{
			return CurrentXP >= XpPerLevel;
		}

		public void AddXp(double _amount)
		{
			CurrentXP += _amount;
			
			//handle lvlup
			if(IsLvlUp())
			{
				LevelUp();
			}
		}


		public void AddHP(double _amount)
		{
			if (HP.CurrentValue < HP.BaseValue)
				HP.CurrentValue += _amount;
			else
				HP.CurrentValue = HP.BaseValue;

		}
		public void SubtractHP(double _amount)
		{
			HP.CurrentValue -= _amount;

			if (IsDie())
				Die();
		}

		//DELEGATES!!!!!!!!	
		private void Die()
		{
			throw new NotImplementedException();
		}

		public bool IsDie()
		{
			return HP.CurrentValue <= 0;
		}



		public void AddStamina(double _amount)
		{
			if (Stamina.CurrentValue < Stamina.BaseValue)
				Stamina.CurrentValue += _amount;
			else
				Stamina.CurrentValue = Stamina.BaseValue;

		}
		public void SubtractStamina(double _amount)
		{
			if((Stamina.CurrentValue - _amount) > 0)
				Stamina.CurrentValue -= _amount;
			else
				Stamina.CurrentValue = 0;
		}
	}

	
}

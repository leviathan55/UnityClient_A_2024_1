using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
    public class Enums
    {
        public enum StoryType
        {
            MAIN,
            SUB = 100,
            SERIAL
        }

        public enum EvenType
        {
            NONE,
            GoToBattle = 100,
            checkSTR = 1000,
            checkDEX,
            CheckCON,
            CHECKWIS,
            CheckCHA
        }
        public enum ResultType
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            Gotoshop,
            GotoNestXtory,
            GoToRandeomStory,
            GoToEnding
        }

        [System.Serializable]
        public class stats
        {
            public int hpPoint;
            public int spPoint;

            public int currentHpPoint;
            public int currentSpPoint;
            public int currentXpPoint;

            public int strength;
            public int dexterity;
            public int consitiution;
            public int Intelligence;
            public int wisdom;
            public int charisma;
        }
    }
}

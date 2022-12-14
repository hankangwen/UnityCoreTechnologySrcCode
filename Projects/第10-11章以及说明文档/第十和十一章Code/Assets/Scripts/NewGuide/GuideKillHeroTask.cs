using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using GameDefine;

using Game.Ctrl;

namespace Game.GuideDate
{
    public class GuideKillHeroTask : GuideTaskBase
    {
        private GuideKillHeroInfo mKillHero;
        private int mKillTimes;

        public GuideKillHeroTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        {

        }

        public override void EnterTask()
        {
           if (!ConfigReader.GuideKillHeroXmlInfoDict.TryGetValue(mTaskId, out mKillHero))
            {
                this.FinishTask();
                return;
            }
            EventCenter.AddListener<int>(EGameEvent.eGameEvent_GuideKillTask, GetKillEvent);
        }

        public override void ExcuseTask()
        {

        }

        public override void ClearTask()
        {
            EventCenter.RemoveListener<int>(EGameEvent.eGameEvent_GuideKillTask, GetKillEvent);
            base.ClearTask();
        }

        private void GetKillEvent(int mType)
        {

            if (mKillHero.mDeadnpcid.Contains(mType))
            {
                mKillTimes++;
            }
            if (mKillTimes >= mKillHero.mTimes)
            {
                this.FinishTask();
            }
        }

    }


}

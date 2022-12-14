using System;
using System.Collections.Generic;
using UnityEngine;
using MO.MOBA.Tools;
using Game.Model;

namespace Game.GuideDate
{
    ////////////////////////////////////////////////////////////引导买符文///////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////引导买符文///////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////引导买符文///////////////////////////////////////////////////////////

    public class GuideLevelToBuyRuneTask : GuideTaskBase
    {

        private const short mLevelCanBuyRune = 3;

        public GuideLevelToBuyRuneTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        {
            
        }

        /// <summary>
        /// 到时广播消息
        /// </summary>
        public override void EnterTask()
        {
            EventCenter.AddListener(EGameEvent.eGameEvent_ChangeUserLevel, OnGuideTaskEvents);
            OnGuideTaskEvents();
        }

        public override void ExcuseTask()
        {

        }

        public override void ClearTask()
        {
            EventCenter.RemoveListener(EGameEvent.eGameEvent_ChangeUserLevel, OnGuideTaskEvents);
            base.ClearTask();
        }

        private void OnGuideTaskEvents()
        {
            if (GameUserModel.Instance.UserLevel >= mLevelCanBuyRune)
            { 
                this.FinishTask();
            }
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using GameDefine;

using Game.Ctrl;
using Game.GameEntity;

namespace Game.GuideDate
{
    public class AdGuideBornStrongSoldierTask : GuideTaskBase
    {
        private AdvancedGuideInfo mGuideInfo;

        public AdGuideBornStrongSoldierTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        {

        }

        public override void EnterTask()
        {
            if (!ConfigReader.AdvancedGuideInfoDict.TryGetValue(this.mTaskId, out mGuideInfo))
            {
                return;
            }
            EventCenter.AddListener<Ientity>(EGameEvent.eGameEvent_NotifyBuildingDes, OnGuideTaskEvents);
            mTaskCDtime = mGuideInfo.CDTime / 1000f;
        }

        public override void ExcuseTask()
        {
            base.ExcuseTask();
        }

        public override void ClearTask()
        {
            EventCenter.RemoveListener<Ientity>(EGameEvent.eGameEvent_NotifyBuildingDes, OnGuideTaskEvents);
            base.ClearTask();
        }

        /// <summary>
        /// 引导任务事件触发
        /// </summary>
        /// <param name="target"></param>
        private void OnGuideTaskEvents(Ientity target)
        {
            if (mIsTaskCoolDown)
            {
                return;
            }
            int gObjId = (int)target.ObjTypeID;
            if (mGuideInfo.EventValue1.Contains(gObjId))
            {
                mIsTaskCoolDown = true;
                mTaskTime = Time.realtimeSinceStartup;
                EventCenter.Broadcast<int>(EGameEvent.eGameEvent_AdvancedGuideShowTip, this.mTaskId);
            }

        }

    }


}

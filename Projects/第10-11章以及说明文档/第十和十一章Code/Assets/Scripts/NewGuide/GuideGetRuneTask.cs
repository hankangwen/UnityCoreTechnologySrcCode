using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using GameDefine;

using Game.Ctrl;

namespace Game.GuideDate
{
    public class GuideGetRuneTask : GuideTaskBase
    {
        public GuideGetRuneTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        {

        }

        public override void EnterTask()
        {
            EventCenter.AddListener<uint, int, long>(EGameEvent.eGameEvent_RuneBagUpdate, GetRuneEvent);
        }

        public override void ExcuseTask()
        {

        }

        public override void ClearTask()
        {
            EventCenter.RemoveListener<uint, int, long>(EGameEvent.eGameEvent_RuneBagUpdate, GetRuneEvent);
            base.ClearTask();
        }

        private void GetRuneEvent(uint runeId, int num, long gottime)
        {
            this.FinishTask();
        }

    }


}

using System;
using System.Collections.Generic;
using UnityEngine;
using GameDefine;
using Game.GameEntity;
using MO.MOBA.Tools;
namespace Game.GuideDate
{
    public class GuideScreenClickTask : GuideTaskBase
    {
        //CAbsorbTask absorbTask = null;

        public GuideScreenClickTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        {
            //读取数据
            //absorbTask = ConfigReader.GetAbsorbTaskInfo(task);
            //if (absorbTask == null)
            //{
            //    Debug.LogError("GuideAbsorbTask 找不到任務 Id" + task);
            //} 
        }

        /// <summary>
        /// 到时广播消息
        /// </summary>
        public override void EnterTask()
        {
            EventCenter.AddListener<Ientity>(EGameEvent.eGameEvent_LockTarget, OnLockTarget);
        }


        public override void ExcuseTask()
        {

        }

        private void OnLockTarget(Ientity mEntity)
        {
            this.FinishTask();
        }

        public override void ClearTask()
        {
            EventCenter.RemoveListener<Ientity>(EGameEvent.eGameEvent_LockTarget, OnLockTarget);
            //EventCenter.RemoveListener<int>(EGameEvent.eGameEvent_GuideAbsorbTask, GetAbsorbEvent);
            //base.ClearTask();
        }


    }


}

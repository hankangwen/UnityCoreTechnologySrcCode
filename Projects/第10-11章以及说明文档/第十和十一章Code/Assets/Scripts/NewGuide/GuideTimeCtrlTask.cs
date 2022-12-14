using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using GameDefine;

namespace Game.GuideDate

{
    public class GuideTimeCtrlTask : GuideTaskBase
    {


        private CTimeCtrlTask timeTask;
        float timeStart;
        public GuideTimeCtrlTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        { 
            //读取数据
            timeTask = ConfigReader.GetTimeCtrlTaskInfo(task);
            if (timeTask == null)
            {
                Debug.LogError("GuideTimeCtrlTask 找不到任務 Id" + task);
            }
        }        

        public override void EnterTask()
        {
            timeStart = Time.time;
        }
        
        public override void ExcuseTask()
        {
            if (Time.time - timeStart >= timeTask.TimeLimit) {
                base.FinishTask();
            }
        }

        public override void ClearTask()
        {            
            base.ClearTask();
            
        }
       
    }


}

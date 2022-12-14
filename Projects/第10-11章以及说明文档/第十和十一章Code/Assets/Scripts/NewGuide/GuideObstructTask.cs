using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using GameDefine;
using Game.GameEntity;
using Game.FSM;
using Game.Resource;

namespace Game.GuideDate

{
    public class GuideObstructTask : GuideTaskBase
    { 
        CObstructTask obsTask = null;
        Iselfplayer player;
        int times = 0;
        DateTime timeShow ;
        GameObject objTip = null;
        public GuideObstructTask(int task, GuideTaskType type, GameObject mParent)
            : base(task, type, mParent)
        { 
            //读取数据
            player = PlayerManager.Instance.LocalPlayer;
            obsTask = ConfigReader.GetObstructTaskInfo(task);
            if (obsTask == null)  
            {
                Debug.LogError("GuideObstructTask 找不到任務 Id" + task);
            } 
        }        

        public override void EnterTask()
        {
           
        }
 
        public override void ExcuseTask()
        {
            if (objTip != null && objTip.activeInHierarchy) {
                TimeSpan sTimeSpan = DateTime.Now - timeShow;
                if (sTimeSpan.TotalSeconds >= obsTask.ObsShowTime) {
                    objTip.gameObject.SetActive(false);
                }
            }
        }


        public override void ClearTask()
        {            
            base.ClearTask();
            if (objTip != null)
            {
                GameObject.DestroyObject(objTip);
            }
        }

        /// <summary>
        /// 每次移动前检测下一步是否进入到阻挡区域里面
        /// </summary>
        /// <param name="pos"></param>
        public  bool MoveCheck(Vector3 pos) {
            float dis = Vector3.Distance(pos,obsTask.ObsCenter);
            if (dis < obsTask.ObsDisance)
            {
                if (PlayerManager.Instance.LocalPlayer.FSM != null && PlayerManager.Instance.LocalPlayer.FSM.State != FsmState.FSM_STATE_FREE)
                {
                    ShowTip();
                }
                return false;
            }
            return true;
        }

        private void ShowTip() { 
            if (times >= obsTask.ObsCount)
                return;            
            if (objTip != null && objTip.activeInHierarchy)
                return;
            if (objTip == null)
            {
                //objTip = GameObject.Instantiate(Resources.Load(obsTask.ObsPath)) as GameObject;
                ResourceUnit objTipUnit = ResourcesManager.Instance.loadImmediate(obsTask.ObsPath, ResourceType.PREFAB);
                objTip = GameObject.Instantiate(objTipUnit.Asset) as GameObject;

                objTip.transform.parent = UINewsGuide.Instance.transform;
                objTip.transform.localPosition = Vector3.zero;
                objTip.transform.localScale = new Vector3(0.9f,0.9f,0.9f);
            }
            timeShow = DateTime.Now;
            times += 1;
            objTip.SetActive(true);
            UILabel label = objTip.GetComponentInChildren<UILabel>();
            label.text = obsTask.ObsTip;
        }
    }

   
}

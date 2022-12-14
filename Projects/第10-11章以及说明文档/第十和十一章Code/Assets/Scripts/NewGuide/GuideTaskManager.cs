using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using GameDefine;

namespace Game.GuideDate

{
    public class GuideTaskManager
    {
        public delegate void FinishTaskEvent();
        public FinishTaskEvent FinishEvent;

        public CTaskManagerData taskData;
        List<GuideTaskBase> taskList = new List<GuideTaskBase>();

        public enum TaskState
        { 
            NoneState,
            EnterState,
            CheckState,
            EndState,
        }

        public TaskState taskState
        {
            private set;
            get;
        }

        public GuideTaskManager(CTaskManagerData data)
        {
            taskData = data;
            taskState = TaskState.NoneState;
            taskList.Clear();
        }

        public void CleanAllTask() {
            if (taskList == null || taskList.Count == 0)
                return;
            foreach (var item in taskList)
            {
                if (item.IsFinish()) continue;
                item.ClearTask();
            }
            taskData = null;
            taskState = TaskState.NoneState;
            taskList.Clear();
            taskList = null; 
        }

        public void SetTaskState(TaskState state) {
            taskState = state;
            switch (state) { 
                case TaskState.EnterState:
                  ResolveTask();
                  EnterTask();
                  break;      
                case TaskState.EndState:
                  FinishTask();
                  break;
            }           
        }

        public void CheckFinishAll()
        {
            if (taskState != TaskState.CheckState) return;
            switch (taskData.MeetCheck)
            {
                case TaskCheckType.AllMeetCheck:
                    if (!CheckAllMeetCheck())
                        return;
                    break;
                case TaskCheckType.AnyMeetCheck:
                    if (!CheckAnyMeetCheck())
                        return;
                    break;
                case TaskCheckType.PartMeetCheck:
                    if (!CheckPartMeetCheck())
                        return;
                    break;
                default:
                    return;
            }
            SetTaskState(TaskState.EndState);      
        }

        public void OnUpdate() {
            if (taskState == TaskState.NoneState) return;
            ExcueseTask();
        }

        private void EnterTask()
        {
            if (taskList == null || taskList.Count == 0) return;
            for (int i = taskList.Count - 1; i >= 0; i--)
            {
                if (taskList == null || taskList.Count <= i) return;
                GuideTaskBase item = taskList.ElementAt(i);
                if (item == null || item.IsFinish()) continue;
                item.EnterTask();
            }   
        }

        private void ExcueseTask()
        {
            if (taskList == null || taskList.Count == 0) return;
            for(int i = taskList.Count - 1;i >= 0 ;i--)  
            {
                if (taskList == null || taskList.Count <= i) return;
                GuideTaskBase item = taskList.ElementAt(i);
                if (item == null || item.IsFinish()) continue;
                item.ExcuseTask();
            }            
        }      


        private bool CheckAnyMeetCheck() {
            List<GuideTaskBase> anyTask = new List<GuideTaskBase>();
            if (taskData.EndTaskSet == null || taskData.EndTaskSet.Count == 0)
            {
                anyTask = taskList;
            }
            else
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    if (taskData.EndTaskSet.Contains(i))
                    {
                        anyTask.Add(taskList.ElementAt(i));
                    }
                }
            }

            foreach (var item in anyTask)
            {
                if (item.IsFinish())
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckAllMeetCheck() {
            foreach (var item in taskList)
            {
                if (!item.IsFinish())
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckPartMeetCheck() {
            List<GuideTaskBase> partTask = new List<GuideTaskBase>();
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskData.EndTaskSet.Contains(i))
                {
                    partTask.Add(taskList.ElementAt(i));
                }
            }
            foreach (var item in partTask)
            {
                if (!item.IsFinish())
                {
                    return false;
                }
            }
            return true;
        }

        private void ResolveTask()
        {
            for (int i = 0; i < taskData.TaskTypeSet.Count; i++)
            {
                GuideTaskBase task = null;
                //switch (taskData.TaskTypeSet.ElementAt(i))
                //{
                //    case GuideTaskType.ClickButtonTask:
                //        task = new GuideClickButtonTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.PathTask:
                //        task = new GuidePathTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.TimeCtrlTask:
                //        task = new GuideTimeCtrlTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.MoveCameraTask:
                //        task = new GuideCameraTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.TipTask:
                //        task = new GuideTipTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.PopTipTask:
                //        task = new GuidePopTipTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.ObstructTask:
                //        task = new GuideObstructTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.VoiceTask:
                //        task = new GuideVoiceTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.ObjFlashTask:
                //        task = new GuideFlashTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.ObjShowTask:
                //        task = new GuideShowObjTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break; 
                //    case GuideTaskType.AbsorbTask:
                //        task = new  GuideAbsorbTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.SenderSoldier:
                //        task = new GuideSendNpcTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.KillTask:
                //        task = new GuideKillTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //    case GuideTaskType.RewardTipTask:
                //        task = new GuideRewardTask(taskData.SonTaskIdSet.ElementAt(i), taskData.TaskTypeSet.ElementAt(i));
                //        break;
                //}                
                //if (task != null)
                //{
                //    taskList.Add(task);
                //}
            }
        }

        void FinishTask() {
            foreach (var item in taskList) {
                if (item.IsFinish()) continue;
                item.ClearTask();
            }
            taskData = null;
            taskState = TaskState.NoneState;
            taskList.Clear();
            taskList = null;
            if (FinishEvent != null)
            {
                FinishEvent();
            }
        }

        public List<GuideObstructTask> GetObstructTask()
        {
            List<GuideObstructTask> taskObs = new List<GuideObstructTask>();
             for (int i = 0; i < taskData.TaskTypeSet.Count; i++)
            {
                if (taskData.TaskTypeSet.ElementAt(i) == GuideTaskType.ObstructTask) {
                   taskObs.Add((GuideObstructTask)taskList.ElementAt(i));
                }
            }
             return taskObs;
        }
    }
}

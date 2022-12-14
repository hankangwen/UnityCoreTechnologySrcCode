using System;
using System.Collections.Generic;
using UnityEngine;
using GameDefine;
using Game.GameEntity;
using MO.MOBA.Tools;
using System.Linq;
using Game.GameData;

namespace Game.GuideDate
{
    public class BuildingAtkWarningManager : Singleton<BuildingAtkWarningManager>
    {        
        private bool isInWarning = false;

        private Dictionary<BuildingAtkWarning, Ientity> objDic = new Dictionary<BuildingAtkWarning, Ientity>();

        public void OnUpdate()
        {
            if (objDic == null || objDic.Count == 0)
                return;
            for (int i = objDic.Count - 1; i >= 0; i--) {
                BuildingAtkWarning warning = objDic.ElementAt(i).Key;
                warning.OnUpdate();
            }
        }

        public void RemoveWarning(BuildingAtkWarning warning)
        {
            warning.Clean();
            objDic.Remove(warning);
            warning = null;
        }


        public BuildingAtkWarningManager()
        {
            EventCenter.AddListener<UInt64, uint, UInt64>(EGameEvent.eGameEvent_BroadcastBeAtk, OnSkillModelHitTarget); 
        }

        ~BuildingAtkWarningManager() {
            EventCenter.RemoveListener<UInt64, uint, UInt64>(EGameEvent.eGameEvent_BroadcastBeAtk, OnSkillModelHitTarget); 
        }

        private void OnSkillModelHitTarget(UInt64 owner, uint efId , UInt64 target)
        {
            if (!CheckCanAdd(owner, target))
            {
                return;
            }
            AddWarning(owner);
        }

        bool CheckCanAdd(UInt64 owner, UInt64 target)
        {
            if (!EntityManager.AllEntitys.ContainsKey(owner) || !EntityManager.AllEntitys.ContainsKey(target))
                return false;
            Ientity ownerEntity = EntityManager.AllEntitys[owner];
            Ientity targetEntity = EntityManager.AllEntitys[target];
            if (ownerEntity == null || ownerEntity.realObject == null || targetEntity == null || targetEntity.realObject == null)
                return false;
            if (ownerEntity.entityType != EntityType.Building || PlayerManager.Instance.LocalPlayer.GameObjGUID != target)
                return false;
            if (ownerEntity.FSM.State == FSM.FsmState.FSM_STATE_DEAD || targetEntity.FSM.State == FSM.FsmState.FSM_STATE_DEAD)
                return false;
            if (ContainWarning(ownerEntity))
                return false;
            return true;
        }

        bool ContainWarning(Ientity entity) { 
           for(int i = objDic.Count - 1;i >= 0;i--){
               BuildingAtkWarning warning = objDic.ElementAt(i).Key;
               if(warning.GetTarget() == entity){
                   return true;
               }
           }
            return false;
        }

        void AddWarning(UInt64 owner)
        {
            Ientity ownerEntity = EntityManager.AllEntitys[owner];
            BuildingAtkWarning warning = new BuildingAtkWarning();
            warning.CreateCircleRes(ownerEntity);
            objDic.Add(warning, ownerEntity);
        } 
        
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;
using GameDefine;
using Game.GameEntity;
using MO.MOBA.Tools;
using System.Linq;
using Game.GameData;
using Game.Resource;

namespace Game.GuideDate
{
    public class BuildingAtkWarning 
    {        
        private bool isInWarning = false;

        private float showTime = 6f;

        private float totalTime = 30f;

        private DateTime startTime;

        private Ientity target = null;

        private GameObject objEffect = null;

        private string AudioPath = "/Audio/UIAudio/JTsj"; 

        public Ientity GetTarget() {
            return target;
        }

        public BuildingAtkWarning() {
            EventCenter.AddListener<Ientity>(EGameEvent.eGameEvent_NotifyBuildingDes, OnBuildingDead);
        }

        ~BuildingAtkWarning() {
            EventCenter.RemoveListener<Ientity>(EGameEvent.eGameEvent_NotifyBuildingDes, OnBuildingDead);
        }

        private void OnBuildingDead(Ientity entity)
        {
            if (entity == target)
            {
                isInWarning = false;
                BuildingAtkWarningManager.Instance.RemoveWarning(this);
            }
        }

        public void OnUpdate()
        {
            if (!isInWarning)
                return;
            TimeSpan span = DateTime.Now - startTime;
            if (span.TotalSeconds > showTime && objEffect != null && objEffect.activeInHierarchy) {
                objEffect.SetActive(false);
            }
            if (span.TotalSeconds > totalTime) {
                isInWarning = false;
                BuildingAtkWarningManager.Instance.RemoveWarning(this);
            }
        } 

        public void CreateCircleRes(Ientity entity)
        {
            target = entity;
            string path = GameConstDefine.LoadGameOtherEffectPath;            
            ResourceUnit objUnit = ResourcesManager.Instance.loadImmediate(path + "guangquan_jianta", ResourceType.PREFAB);
            GameObject obj = GameObject.Instantiate(objUnit.Asset) as GameObject;
            obj.transform.parent = entity.realObject.transform;
            obj.transform.position = entity.realObject.transform.position + new Vector3(0.0f, 0.2f, 0.0f);
            obj.transform.localRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            int skillID = ConfigReader.NpcXmlInfoDict[entity.NpcGUIDType].NpcSkillType1;
            float range = ConfigReader.GetSkillManagerCfg(skillID).range;
            float rate = 1f / 16f;
            obj.transform.localScale = new Vector3(range * rate / entity.RealEntity.transform.localScale.x, 1.0f, range * rate / entity.RealEntity.transform.localScale.z);
            startTime = DateTime.Now;            
            objEffect = obj;
            ResourceUnit clipUnit = ResourcesManager.Instance.loadImmediate(AudioPath, ResourceType.PREFAB);
            AudioClip clip = clipUnit.Asset as AudioClip;
            AudioManager.Instance.PlayEffectAudio(clip);
            isInWarning = true;         
        }

        public void Clean() {
            if(objEffect != null){
                GameObject.DestroyImmediate(objEffect);
            }
            objEffect = null;
            isInWarning = false;
            target = null;
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using MO.MOBA.Tools;
using Game.GameData;
using Game.GameEntity;
namespace Game.Effect
{
    public class PassitiveEffect : IEffect
    {
        public PassitiveEffect()
        {
            mType = IEffect.ESkillEffectType.eET_Passive;
        }

        public Ientity entity;        
        public int InstID;
 
        public override void OnLoadComplete()
        {
            if (entity == null)
            {
                return;
            }
            GetTransform().parent = entity.RealEntity.objPoint.transform;
            GetTransform().position = entity.RealEntity.objPoint.transform.position;
        }

        public override void Update()
        {
            if (isDead)
                return;                  

            base.Update();
        }				


    }
}

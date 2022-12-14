using UnityEngine;
using System.Collections;

namespace Game.Ctrl
{
    public class SoleSoldierCtrl : Singleton<SoleSoldierCtrl>
    {
        public void Enter()
        {
            EventCenter.Broadcast(EGameEvent.eGameEvent_SoleSoldierEnter);
        }
        public void Exit()
        {
            EventCenter.Broadcast(EGameEvent.eGameEvent_SoleSoldierExit);
        }
    }
}

using UnityEngine;
using System.Collections;


namespace Game.Ctrl
{
    /// /////////////////////////// ////////////////////////////   进阶引导  /// /////////////////////////// ////////////////////////
    /// /// /////////////////////////// ////////////////////////   进阶引导  /// /////////////////////////// //////////////////////// 
    /// /// /////////////////////////// ////////////////////////   进阶引导  /// /////////////////////////// //////////////////////// 

    public class AdvancedGuideCtrl : Singleton<AdvancedGuideCtrl>
    {
        public AdvancedGuideCtrl()
        { 

        }

        public void Enter()
        {
            EventCenter.Broadcast(EGameEvent.eGameEvent_AdvancedGuideEnter);
        }

        public void Exit()
        {
            EventCenter.Broadcast(EGameEvent.eGameEvent_AdvancedGuideExit);
        }
    }
}


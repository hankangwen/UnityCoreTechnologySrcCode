using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
#if !(UNITY_4_0 || UNITY_4_0_1 || UNITY_4_1 || UNITY_4_2 || UNITY_4_3)
using Tooltip = BehaviorDesigner.Runtime.Tasks.TooltipAttribute;
#endif

namespace BehaviorDesigner.Samples
{
    [TaskCategory("RTS")]
    [TaskDescription(@"Set the target with the next attack position from the enemy building. Seek will then use this position to seek to. We can't use 
                       the target's transform because we need a Vector3 of the attack position which is an offset of the target's transform position")]
    public class NextAttackPosition : Action
    {
        [InheritedField]
        [Tooltip("The enemy building that will let us know the next attack position")]
        public SharedTransform target;
        [Tooltip("Returned Vector3 of the target position")]
        public SharedVector3 targetPosition;

        // will return success after the target has been set
        public override TaskStatus OnUpdate()
        {
            targetPosition.Value = target.Value.GetComponent<EnemyBuilding>().nextAttackPosition();
            return TaskStatus.Success;
        }
    }
}
using UnityEngine;
using System;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks
{
    [TaskDescription("Gets the value from the field specified. Returns success if the field was retrieved.")]
    [HelpURL("http://www.opsive.com/assets/BehaviorDesigner/documentation.php?id=147")]
    [TaskCategory("Reflection")]
    [TaskIcon("{SkinColor}ReflectionIcon.png")]
    public class GetFieldValue : Action
    {
        [Tooltip("The GameObject to get the field on")]
        public SharedGameObject targetGameObject;
        [Tooltip("The component to get the field on")]
        public SharedString componentName;
        [Tooltip("The name of the field")]
        public SharedString fieldName;
        [Tooltip("The value of the field")]
        [RequiredField]
        public SharedVariable fieldValue;

        public override TaskStatus OnUpdate()
        {
            if (fieldValue == null) {
                Debug.LogWarning("Unable to get field - field value is null");
                return TaskStatus.Failure;
            }

            if (targetGameObject == null || targetGameObject.Value == null) {
                Debug.LogWarning("Unable to get field - target GameObject is null");
                return TaskStatus.Failure;
            }

            var component = targetGameObject.Value.GetComponent(Type.GetType(componentName.Value));
            if (component == null) {
                Debug.LogWarning("Unable to get the field with component " + componentName.Value);
                return TaskStatus.Failure;
            }

            var field = component.GetType().GetField(fieldName.Value);
            fieldValue.SetValue(field.GetValue(component));

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            targetGameObject = null;
            componentName = null;
            fieldName = null; 
            fieldValue = null;
        }
    }
}
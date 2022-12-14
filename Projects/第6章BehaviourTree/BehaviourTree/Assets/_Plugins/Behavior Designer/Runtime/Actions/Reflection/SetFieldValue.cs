using UnityEngine;
using System;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks
{
    [TaskDescription("Sets the field to the value specified. Returns success if the field was set.")]
    [HelpURL("http://www.opsive.com/assets/BehaviorDesigner/documentation.php?id=149")]
    [TaskCategory("Reflection")]
    [TaskIcon("{SkinColor}ReflectionIcon.png")]
    public class SetFieldValue : Action
    {
        [Tooltip("The GameObject to set the field on")]
        public SharedGameObject targetGameObject;
        [Tooltip("The component to set the field on")]
        public SharedString componentName;
        [Tooltip("The name of the field")]
        public SharedString fieldName;
        [Tooltip("The value to set")]
        public SharedVariable fieldValue;

        public override TaskStatus OnUpdate()
        {
            if (fieldValue == null) {
                Debug.LogWarning("Unable to get field - field value is null");
                return TaskStatus.Failure;
            }

            if (targetGameObject == null || targetGameObject.Value == null) {
                Debug.LogWarning("Unable to set field");
                return TaskStatus.Failure;
            }

            var component = targetGameObject.Value.GetComponent(Type.GetType(componentName.Value));
            if (component == null) {
                Debug.LogWarning("Unable to set the field with component " + componentName.Value);
                return TaskStatus.Failure;
            }

            var field = component.GetType().GetField(fieldName.Value);
            field.SetValue(component, fieldValue.GetValue());

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
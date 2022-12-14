using UnityEngine;
using System;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks
{
    [TaskDescription("Gets the value from the property specified. Returns success if the property was retrieved.")]
    [HelpURL("http://www.opsive.com/assets/BehaviorDesigner/documentation.php?id=148")]
    [TaskCategory("Reflection")]
    [TaskIcon("{SkinColor}ReflectionIcon.png")]
    public class GetPropertyValue : Action
    {
        [Tooltip("The GameObject to get the property of")]
        public SharedGameObject targetGameObject;
        [Tooltip("The component to get the property of")]
        public SharedString componentName;
        [Tooltip("The name of the property")]
        public SharedString propertyName;
        [Tooltip("The value of the property")]
        [RequiredField]
        public SharedVariable propertyValue;

        public override TaskStatus OnUpdate()
        {
            if (propertyValue == null) {
                Debug.LogWarning("Unable to get property - property value is null");
                return TaskStatus.Failure;
            }

            if (targetGameObject == null || targetGameObject.Value == null) {
                Debug.LogWarning("Unable to get property - target GameObject is null");
                return TaskStatus.Failure;
            }

            var component = targetGameObject.Value.GetComponent(Type.GetType(componentName.Value));
            if (component == null) {
                Debug.LogWarning("Unable to get the property with component " + componentName.Value);
                return TaskStatus.Failure;
            }

            var property = component.GetType().GetProperty(propertyName.Value);
            propertyValue.SetValue(property.GetValue(component, null));

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            targetGameObject = null;
            componentName = null;
            propertyName = null;
            propertyValue = null;
        }
    }
}
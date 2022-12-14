using UnityEngine;
using System;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks
{
    [TaskDescription("Compares the property value to the value specified. Returns success if the values are the same.")]
    [HelpURL("http://www.opsive.com/assets/BehaviorDesigner/documentation.php?id=152")]
    [TaskCategory("Reflection")]
    [TaskIcon("{SkinColor}ReflectionIcon.png")]
    public class ComparePropertyValue : Conditional
    {
        [Tooltip("The GameObject to compare the property of")]
        public SharedGameObject targetGameObject;
        [Tooltip("The component to compare the property of")]
        public SharedString componentName;
        [Tooltip("The name of the property")]
        public SharedString propertyName;
        [Tooltip("The value to compare to")]
        public SharedVariable compareValue;

        public override TaskStatus OnUpdate()
        {
            if (compareValue == null) {
                Debug.LogWarning("Unable to compare field - compare value is null");
                return TaskStatus.Failure;
            }

            if (targetGameObject == null || targetGameObject.Value == null) {
                Debug.LogWarning("Unable to compare the property");
                return TaskStatus.Failure;
            }

            var component = targetGameObject.Value.GetComponent(Type.GetType(componentName.Value));
            if (component == null) {
                Debug.LogWarning("Unable to compare the property with component " + componentName.Value);
                return TaskStatus.Failure;
            }

            var property = component.GetType().GetProperty(propertyName.Value);
            var propertyValue = property.GetValue(component, null);

            if (propertyValue == null && compareValue.GetValue() == null) {
                return TaskStatus.Success;
            }

            return propertyValue.Equals(compareValue.GetValue()) ? TaskStatus.Success : TaskStatus.Failure;
        }

        public override void OnReset()
        {
            targetGameObject = null;
            componentName = null;
            propertyName = null;
            compareValue = null;
        }
    }
}
using UnityEditor;
using UnityEngine;
using Smoothie.MonetColors.Runtime;

namespace Smoothie.MonetColors.Editor
{
    [CustomEditor(typeof(MonetColorer), true), CanEditMultipleObjects]
    public class MonetColorerCustomEditor : UnityEditor.Editor
    {
        private SerializedProperty _color;

        private void OnEnable()
        {
            _color = serializedObject.FindProperty("_color");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            var uiElement = target as MonetColorer;
            uiElement.UpdateColor();
            EditorGUILayout.PropertyField(_color);
            EditorGUILayout.LabelField(Colors.Names[_color.intValue]);

            serializedObject.ApplyModifiedProperties();
        }
    }
}

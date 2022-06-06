using UnityEngine;
using UnityEngine.UI;
using System;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(Shadow))]
    public class ShadowMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            Shadow shadow = null;
            foreach (var component in GetComponents<Shadow>()) if (component.GetType() == typeof(Shadow)) shadow = component;
            if (shadow != null)
            {
                _colorValue.a = shadow.effectColor.a;
                shadow.effectColor = _colorValue;
            }
            else throw new NullReferenceException("You don't have a Shadow component. or something went wrong...");
        }
    }
}

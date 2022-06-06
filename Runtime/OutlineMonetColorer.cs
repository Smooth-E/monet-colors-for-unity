using UnityEngine;
using UnityEngine.UI;
using System;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(Outline))]
    public class OutlineMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            Outline outline = null;
            foreach (var component in GetComponents<Outline>()) if (component.GetType() == typeof(Outline)) outline = component;
            if (outline != null)
            {
                _colorValue.a = outline.effectColor.a;
                outline.effectColor = _colorValue;
            }
            else throw new NullReferenceException("You don't have an Outline component. or something went wrong...");
        }
    }
}

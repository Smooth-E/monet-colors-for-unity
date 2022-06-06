using UnityEngine;
using UnityEngine.UI;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(Text))]
    public class TextMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            var component = GetComponent<Text>();
            _colorValue.a = component.color.a;
            component.color = _colorValue;
        }
    }
}

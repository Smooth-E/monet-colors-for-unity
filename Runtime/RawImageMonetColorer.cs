using UnityEngine;
using UnityEngine.UI;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(RawImage))]
    public class RawImageMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            var component = GetComponent<RawImage>();
            _colorValue.a = component.color.a;
            component.color = _colorValue;
        }
    }
}

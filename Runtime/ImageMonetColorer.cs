using UnityEngine;
using UnityEngine.UI;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(Image))]
    public class ImageMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            var component = GetComponent<Image>();
            _colorValue.a = component.color.a;
            component.color = _colorValue;
        }
    }
}

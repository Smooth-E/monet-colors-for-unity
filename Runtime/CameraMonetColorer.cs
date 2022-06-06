using UnityEngine;
using UnityEngine.UI;

namespace Smoothie.MonetColors.Runtime
{
    [RequireComponent(typeof(Camera))]
    public class CameraMonetColorer : MonetColorer
    {
        public override void UpdateColor()
        {
            base.UpdateColor();
            var component = GetComponent<Camera>();
            _colorValue.a = component.backgroundColor.a;
            component.backgroundColor = _colorValue;
        }
    }
}

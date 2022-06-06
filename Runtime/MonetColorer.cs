using UnityEngine;

namespace Smoothie.MonetColors.Runtime
{
    public class MonetColorer : MonoBehaviour
    {
        [SerializeField, Range(0, 51)] protected int _color;

        protected Color _colorValue;

        private void Awake() => UpdateColor();

        public virtual void UpdateColor() => _colorValue = Colors.GetColor(_color);
    }
}

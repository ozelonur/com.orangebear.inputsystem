using UnityEngine.EventSystems;

namespace OrangeBear.InputSystem
{
    public class VariableJoystick : Joystick
    {
        #region Event Sytem Methods

        public override void OnPointerDown(PointerEventData eventData)
        {
            background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
            base.OnPointerDown(eventData);
        }

        #endregion
    }
}
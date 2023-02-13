using UnityEngine;

namespace OrangeBear.InputSystem
{
    [CreateAssetMenu(fileName = "Joystick Settings", menuName = "Orange Bear/Settings/Joystick Settings", order = 1)]
    public class JoystickSettings : ScriptableObject
    {
        #region Serialized Fields

        [Header("Configurations")] [SerializeField]
        public float handleRange = 1f;

        public float deadZone;
        public AxisOptions axisOptions = AxisOptions.Both;

        #endregion
    }
}
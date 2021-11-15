using UnityEngine;
using UnityEngine.InputSystem;
using PixelCrushers;

public class RegisterMyControls : MonoBehaviour
{
    protected static bool isRegistered = false;
    private bool didIRegister = false;
    private MyControls controls;

    void Awake()
    {
        controls = new MyControls();
    }
    void OnEnable()
    {
        if (!isRegistered)
        {
            isRegistered = true;
            didIRegister = true;
            controls.Enable();
            InputDeviceManager.RegisterInputAction("Interact", controls.PlayerActions.Interact);
            InputDeviceManager.RegisterInputAction("Move", controls.PlayerActions.Move);
            InputDeviceManager.RegisterInputAction("Submit", controls.PlayerActions.Submit);
        }
    }
    void OnDisable()
    {
        if (didIRegister)
        {
            isRegistered = false;
            didIRegister = false;
            controls.Disable();
            InputDeviceManager.UnregisterInputAction("Interact");
            InputDeviceManager.UnregisterInputAction("Move");
            InputDeviceManager.UnregisterInputAction("Submit");
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

namespace TrellOfDarkness.Input
{
    public class InputController : MonoBehaviour
    {
        public static InputController Instance
        {
            get
            {
                if (s_instance == null)
                {
                    new GameObject(Name).AddComponent<InputController>();
                }
                return s_instance;
            }
            private set 
            { 
                s_instance = value; 
            }
        }
        public InputData Data { get; private set; }

        private Camera _mainCamera;

        private static InputController s_instance;

        private const string Name = "InputController";

        public void Awake()
        {
            _mainCamera = Camera.main;
            
            if (s_instance == null)
            {
                Data = new InputData();
                Data.Enable();
                s_instance = this;
                DontDestroyOnLoad(gameObject);
            }

            else if (FindObjectsOfType<InputController>().Length > 1)
            {
                Destroy(this);
            }
        }

        public Vector2 GetMousePositionInWorldSpace()
        {
           return _mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        }

    }
}
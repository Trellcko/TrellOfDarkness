using UnityEngine;


using TrellOfDarkness.Input;
using TrellOfDarkness.Physics.Movement;
using TrellOfDarkness.Animation;

namespace TrellOfDarkness.Characters.Player
{
    public class PlayerMovement
        : MonoBehaviour
    {
        [SerializeField] private  Movement _movement;
        [SerializeField] private MovementAnimation _animator;

        private void OnEnable()
        {
            InputController.Instance.Data.Player.Movement.performed += MoveTowards;
            InputController.Instance.Data.Player.Movement.canceled += StopMovement;
        }

        private void OnDisable()
        {
            InputController.Instance.Data.Player.Movement.performed -= MoveTowards;
            InputController.Instance.Data.Player.Movement.canceled -= StopMovement;
        }

        private void MoveTowards(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _movement.Move(obj.ReadValue<Vector2>().normalized);
            _animator.PlayMove();
        }

        private void StopMovement(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _movement.Move(Vector2.zero);
            _animator.StopPlayMove();
        }


    }
}
using UnityEngine;

namespace TrellOfDarkness.Animation
{
    public class CastingAnimation : MonoBehaviour
    {
        private Animator _animator;

        private const string Cast = "Cast";

        public void PlayCast()
        {
            _animator.SetTrigger(Cast);
        }
    }
}
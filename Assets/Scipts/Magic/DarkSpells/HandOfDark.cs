using TrellOfDarkness.Animation;
using UnityEngine;

namespace TrellOfDarkness.Magic.DarkSpell
{
    public class HandOfDark : MonoBehaviour, IDarkSpell
    {
        [SerializeField] private CastingAnimation _animator;
        public void Cast()
        {
            _animator.PlayCast();
        }
    }
}
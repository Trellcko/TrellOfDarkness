using UnityEngine;

using TrellOfDarkness.Input;

namespace TrellOfDarkness.Transform.Flipping
{
    public class MouseFlipping : MonoBehaviour
    {
        private void Update()
        {
            Vector3 theScale = transform.localScale;
            int factor = transform.position.x > InputController.Instance.GetMousePositionInWorldSpace().x ? -1 : 1;
            theScale.x = factor * Mathf.Abs(theScale.x);
            transform.localScale = theScale;
        }
    }
}
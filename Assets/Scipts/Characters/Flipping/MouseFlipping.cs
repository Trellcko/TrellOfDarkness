using System.Collections;
using System.Collections.Generic;
using TrellOfDarkness.Input;
using UnityEngine;

namespace TrellOfDarkness.Characters.Flipping
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
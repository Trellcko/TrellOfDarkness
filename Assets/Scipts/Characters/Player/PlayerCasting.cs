using System.Collections.Generic;
using UnityEngine;

using TrellOfDarkness.Magic.DarkSpell;
using System.Linq;

namespace TrellOfDarkness.Characters.Player
{
    public class PlayerCasting : MonoBehaviour
    {
        [SerializeField] private GameObject _darkSpellsParent;

        private List<IDarkSpell> _darkSpells = new List<IDarkSpell>();

        private void Awake()
        {
            _darkSpells = _darkSpellsParent.GetComponentsInChildren<IDarkSpell>().ToList();
        }

    }
}
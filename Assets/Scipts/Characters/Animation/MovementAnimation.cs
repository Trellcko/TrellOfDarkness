﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrellOfDarkness.Characters.Animation
{
    [RequireComponent(typeof(Animator))]
    public class MovementAnimation : MonoBehaviour
    {
        private Animator _animator;

        private const string IsMoving = "IsMoving";

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void PlayMove()
        {
            _animator.SetBool(IsMoving, true);
        }

        public void StopPlayMove()
        {
            _animator.SetBool(IsMoving, false);
        }
    }
}
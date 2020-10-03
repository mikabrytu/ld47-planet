using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class NoteComponent : MonoBehaviour
    {
        [SerializeField] private GameManager _manager;
        [SerializeField] private ParticleSystem _particle;

        public bool activated = false;

        private void Start()
        {

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && !activated)
            {
                activated = true;
                _particle.Play();

                _manager.IncreaseNotes();
            }
        }

        public void Reset()
        {
            activated = false;
        }

        public void Failure()
        {
            if (!activated)
                _manager.Reset();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class NoteComponent : MonoBehaviour
    {
        [SerializeField] private Material _material;
        [SerializeField] private GameManager manager;

        public bool activated = false;

        private Material original;

        private void Start()
        {
            original = GetComponent<Renderer>().material;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && !activated)
            {
                GetComponent<Renderer>().material = _material;
                activated = true;

                manager.IncreaseNotes();
            }
        }

        public void Reset()
        {
            activated = false;
            GetComponent<Renderer>().material = original;
        }

        public void Failure()
        {
            if (!activated)
                manager.Reset();
        }
    }
}

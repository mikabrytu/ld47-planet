using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mikabrytu.LD47.Components;

namespace Mikabrytu.LD47
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private List<NoteComponent> _notes;
        [SerializeField] private Renderer _planet;
        [SerializeField] private Material _material;

        private int noteCount = 0;

        public void IncreaseNotes()
        {
            noteCount++;

            if (noteCount == _notes.Count)
            {
                _planet.material = _material;
            }
        }

        public void Reset()
        {
            noteCount = 0;

            foreach (NoteComponent note in _notes)
            {
                note.Reset();
            }
        }
    }
}

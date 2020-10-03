using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mikabrytu.LD47.Components;

namespace Mikabrytu.LD47
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private List<NoteComponent> _notes;

        private int noteCount = 0;

        public void IncreaseNotes()
        {
            noteCount++;

            if (noteCount == _notes.Count)
            {
                Debug.Log("Rotation Complete!");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class AttemptComponent : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                transform.parent.GetComponent<NoteComponent>().Failure();
            }
        }
    }
}

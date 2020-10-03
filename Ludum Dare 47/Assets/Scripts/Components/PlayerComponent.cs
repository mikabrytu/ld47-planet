using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class PlayerComponent : MonoBehaviour
    {
        [SerializeField] private float _force;

        private Rigidbody rigidbody;
        private bool canJump = true;

        private void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (canJump && Input.GetButtonDown("Jump"))
            {
                canJump = false;

                rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Ground" && !canJump)
            {
                canJump = true;
            }
        }
    }
}

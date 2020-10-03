using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class PlayerComponent : MonoBehaviour
    {
        [SerializeField] private float _force;

        private Rigidbody2D body;
        private bool canJump = true;

        private void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (canJump && Input.GetButtonDown("Jump"))
            {
                canJump = false;

                body.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground" && !canJump)
            {
                canJump = true;
            }
        }
    }
}

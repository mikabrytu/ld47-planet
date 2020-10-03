using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class OrbitComponent : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.RotateAround(_target.position, Vector3.forward, _speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.LD47.Components
{
    public class PlanetComponent : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}

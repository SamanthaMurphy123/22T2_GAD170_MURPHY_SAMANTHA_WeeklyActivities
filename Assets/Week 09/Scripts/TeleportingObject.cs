using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{
    public class TeleportingObject : MonoBehaviour
    {
        private Vector3 teleportLocation;

        private void OnEnable()
        {
            //Start listening to our "space bar" event
            EventManager.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            //Stop listening to our "space bar" event
            EventManager.OnClicked -= Teleport;
        }

        private void Start()
        {
            teleportLocation = transform.position;
        }
        private void Teleport()
        {
            transform.position = teleportLocation;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{
    public class MarbleCatcher : MonoBehaviour
    {
        [SerializeField] private GameObject marbleSpawnPoint;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.transform.position = marbleSpawnPoint.transform.position;
                other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }



    }
}


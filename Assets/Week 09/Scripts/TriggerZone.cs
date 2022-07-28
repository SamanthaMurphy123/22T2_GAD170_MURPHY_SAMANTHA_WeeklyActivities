using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{
    public class TriggerZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name + " entered trigger zone!!");

            other.gameObject.transform.position = new Vector3(0, 6, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}


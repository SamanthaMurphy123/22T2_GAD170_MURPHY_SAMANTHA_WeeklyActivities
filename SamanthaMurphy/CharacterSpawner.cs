using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;   //Reference to that prefab (a variable)
    [SerializeField] private Transform playerSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);      //Spawn it
    }

}


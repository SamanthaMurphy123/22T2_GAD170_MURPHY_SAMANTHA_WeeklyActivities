using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private int count = 10;

    // Start is called before the first frame update
    void Start()
    {
        // We want to spawn our player character when the game starts.
        // What do we need?
        // - Make a player character prefab             ?
        // - A reference to that prefab (a variable)    ?
        // - Spawn it ("Instantiate")                   ?
        Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);

       

    }
}


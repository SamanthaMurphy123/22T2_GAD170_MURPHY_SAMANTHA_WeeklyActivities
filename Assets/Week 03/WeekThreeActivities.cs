using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekThreeActivities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Samantha Murphy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerLevel()
    {
        float strength = Random.Range(0,11);
        float agility = Random.Range(0,11);
        float intelligence = Random.Range(0,11);
        float totalPower = Random.Range(0,11);

        totalPower = (strength * 2) + (agility * 1.5f) + intelligence;
    }

}

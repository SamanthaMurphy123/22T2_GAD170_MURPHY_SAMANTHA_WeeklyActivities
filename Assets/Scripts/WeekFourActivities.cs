using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 364;

        if (year > 364)
        {
            Debug.Log("This is a leap year.");
        }
        else
        {
            Debug.Log("This is a normal year.");
        }

        int farenheit = Random.Range(-5, 101);
        float celcius = (farenheit - 32) / 1.8f;

        Debug.Log("If farenheit = " + farenheit + " Then Celcius = " + celcius);

        if (celcius <= 0)
        {
            Debug.Log("Its freezing!");
        }
        if (celcius >= 0 && celcius <= 10)
        {
            Debug.Log("It's cold.");
        }
        if (celcius <= 14 && celcius >= 10)
        {
            Debug.Log("It's a bit cool.");
        }
        if (celcius >= 20 && celcius <= 30)
        {
            Debug.Log("It's normal weather");
        }
        if (celcius >= 30 && celcius <=35)
        {
            Debug.Log("its a nice qld day");
        }
        if(celcius <= 37 && celcius >= 35)
        {
            Debug.Log("its getting warmer");
        }
        if (celcius >= 37 && celcius < 40)
        {
            Debug.Log("its hotttttttt!!!!!");
        }
        if (celcius >= 40)
        {
            Debug.Log("Stay inside or you'll melt");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

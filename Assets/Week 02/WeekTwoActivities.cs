using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string favouriteGame = "It Takes Two";   //favourite game
        private int hoursPlayed = 20;                    //How many hours I've played it for
        private float gamePrice = 49.95f;                //How much it cost to buy the game


        // Start is called before the first frame update
        void Start()
        {
            int randomNumber = Random.Range(1, 10);            //Random number

            Debug.Log("My Favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours, and it cost me $" + gamePrice + ". Therefore, my value of dollars per hour is: " + gamePrice / hoursPlayed);

            if (randomNumber == 1)
            {
                Debug.Log("The number was exactly one");
            }
            else if (randomNumber > 3)
            {
                Debug.Log("The number was greater than three");
            }
            else if (randomNumber < 3 || randomNumber > 5)
            {
                Debug.Log("The number was less than three or greater than 5.");
            }
            else if (randomNumber > 1 && randomNumber < 5)
            {
                Debug.Log("The number was greater than one and less than 5; or the number was greater than 5");
            }




        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}



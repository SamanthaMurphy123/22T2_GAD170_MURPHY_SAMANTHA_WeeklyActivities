using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{ 
    public class WeekEightActivities : MonoBehaviour
    {
        public enum Fruit
        {
            Grape,
            Mango,
            Orange,
            Pineapple,
            Strawberry

        }

        public Fruit favouriteFruit;

        public Fruit[] myFruitBasket = new Fruit[10];

        

        
        private void Start()
        {
           // favouriteFruit = Fruit.Pineapple;

            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                // myFruitBasket[i] = Fruit.Mango;

               //  Debug.Log("The fruit I picked out of my basket was a " + myFruitBasket[i]);

                //favouriteFruit = (Fruit)Random.Range(0,11);

                // Debug.Log("Fruit: " + favouriteFruit[i]);

                CheckFruit(myFruitBasket[i]);
            }

            
        }

        private void CheckFruit(Fruit typeOfFruit)
        {
            switch (typeOfFruit)
            {
                case Fruit.Grape:
                    break;
                case Fruit.Mango:
                    break;
                case Fruit.Orange:
                    break;
                case Fruit.Pineapple:
                    Debug.Log("My Favourite Fruit!!!!!!!");
                    break;
                case Fruit.Strawberry:
                    break;
                default:
                    break;
            }


        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamanthaMurphy
{
    public class ResetCounter : MonoBehaviour
    {
        public delegate void MarbleResetAction();
        public static event MarbleResetAction OnMarbleReset;

        //We need to have a counter and we need to increase the counters value every time the marble resets
        [SerializeField] private int resetCount = 0;

        private void OnEnable()
        {
            OnMarbleReset += IncreaseResetCount;     
        }

        private void OnDisable()
        {
            OnMarbleReset -= IncreaseResetCount;

        }

        private void IncreaseResetCount()
        {
            resetCount++;
        }



    }

}

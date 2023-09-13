using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PhEngine.Core;

namespace SuperGame
{
    public class Victory : Singleton<Victory>
    {
        private int winCounter = 0;
        public GameObject winUi;
        private WaitForSeconds waitTimes = new WaitForSeconds(3f);
        protected override void InitAfterAwake()
        {

        }
        public void IncrementCounter()
        {
            winCounter++;
            PressComplete();
        }

        public void PressComplete()
        {
            if (winCounter == 5)
            {
                winUi.SetActive(true);
                StartCoroutine(ShowUI());
            }
        }

        private IEnumerator ShowUI()
        {
            yield return waitTimes;
            winUi.SetActive(false);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PhEngine.Core;

namespace SuperGame
{
    public class CoinsAchievement : Singleton<CoinsAchievement>
    {
        private int coinsCounter = 0;
        public GameObject coinUi;
        private WaitForSeconds waitTimes = new WaitForSeconds(3f);
        protected override void InitAfterAwake()
        {

        }
        public void IncrementCounter()
        {
            coinsCounter++;
            PressComplete();
        }

        public void PressComplete()
        {
            if (coinsCounter == 5)
            {
                coinUi.SetActive(true);
                StartCoroutine(ShowUI());
            }
        }

        private IEnumerator ShowUI()
        {
            yield return waitTimes;
            coinUi.SetActive(false);
        }
    }
}


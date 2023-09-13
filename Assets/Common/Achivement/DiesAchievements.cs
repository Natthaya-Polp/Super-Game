using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PhEngine.Core;

namespace SuperGame
{
    public class DiesAchievements : Singleton<DiesAchievements>
    {
        private int diesCounter = 0;
        public GameObject diesUi;
        private WaitForSeconds waitTimes = new WaitForSeconds(3f);
        protected override void InitAfterAwake()
        {

        }
        public void IncrementCounter()
        {
            diesCounter++;
            PressComplete();
        }

        public void PressComplete()
        {
            if (diesCounter == 5)
            {
                diesUi.SetActive(true);
                StartCoroutine(ShowUI());
            }
        }

        private IEnumerator ShowUI()
        {
            yield return waitTimes;
            diesUi.SetActive(false);
        }
    }
}

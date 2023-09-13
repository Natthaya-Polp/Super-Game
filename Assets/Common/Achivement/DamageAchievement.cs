using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PhEngine.Core;
namespace SuperGame
{
    public class DamageAchievement : Singleton<DamageAchievement>
    {
        private int damageCounter = 0;
        public GameObject damageUi;
        private WaitForSeconds waitTimes = new WaitForSeconds(3f);
        protected override void InitAfterAwake()
        {

        }
        public void IncrementCounter()
        {
            damageCounter++;
            PressComplete();
        }

        public void PressComplete()
        {
            if (damageCounter == 5)
            {
                damageUi.SetActive(true);
                StartCoroutine(ShowUI());
            }
        }

        private IEnumerator ShowUI()
        {
            yield return waitTimes;
            damageUi.SetActive(false);
        }
    }
}



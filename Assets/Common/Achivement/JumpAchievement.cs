using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PhEngine.Core;

namespace SuperGame
{
    public class JumpAchievement : Singleton<JumpAchievement>
    {
        private int eCounter = 0;
        public GameObject Eui;
        private WaitForSeconds waitTimes = new WaitForSeconds(3f);
        protected override void InitAfterAwake()
        {
            
        }
        public void IncrementCounter()
        {
            eCounter++;
            Debug.Log(" Jump " + eCounter + "Times");
            PressComplete();
        }

        public void PressComplete()
        {
            if (eCounter == 5)
            {
                Eui.SetActive(true);
                StartCoroutine(ShowUI());
            }
        }

        private IEnumerator ShowUI()
        {
            yield return waitTimes;
            Eui.SetActive(false);
        }
    }
}

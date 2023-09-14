using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using PhEngine.Core;

namespace SuperGame
{
    public class CoinsAchievement : Singleton<CoinsAchievement>
    {
        [SerializeField] public GameObject coinUi;
        [SerializeField] public Slider coinProgress;
        [SerializeField] public TMP_Text coinPercent;
        [SerializeField] public Animation coinNotiAnimation;
        
        private int coinsCounter = 0;
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
            if (coinsCounter == 100)
            {
                // coinUi.SetActive(true);
                // StartCoroutine(ShowUI());
                coinNotiAnimation.Play();
            }
        }

        // private IEnumerator ShowUI()
        // {
        //     yield return waitTimes;
        //     coinUi.SetActive(false);
        // }

        public void Update()
        {
            float coinsValue = (float)coinsCounter/100;
            
            if (coinsCounter >= 100)
            {
                coinPercent.text = "100%";
                coinProgress.value = 1;
            }
            else
            {
                coinPercent.text = (coinsCounter + "%");
                coinProgress.value = coinsValue;
            }
        }
    }
}


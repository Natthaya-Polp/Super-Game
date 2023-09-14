using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using PhEngine.Core;

namespace SuperGame
{
    public class DiesAchievements : Singleton<DiesAchievements>
    {
        [SerializeField] public GameObject diesUi;
        [SerializeField] public Slider diesProgress;
        [SerializeField] public TMP_Text diesPercent;
        [SerializeField] public Animation diesNotiAnimation;
        
        private int diesCounter = 0;
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
            if (diesCounter == 10)
            {
                // diesUi.SetActive(true);
                // StartCoroutine(ShowUI());
                diesNotiAnimation.Play();
            }
        }

        // private IEnumerator ShowUI()
        // {
        //     yield return waitTimes;
        //     diesUi.SetActive(false);
        // }

        public void Update()
        {
            float diesValue = (float)diesCounter/10;
            
            if (diesCounter >= 100)
            {
                diesPercent.text = "100%";
                diesProgress.value = 1;
            }
            else
            {
                diesPercent.text = (diesCounter*10 + "%");
                diesProgress.value = diesValue;
            }
        }
    }
}

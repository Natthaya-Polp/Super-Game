using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using PhEngine.Core;

namespace SuperGame
{
    public class DamageAchievement : Singleton<DamageAchievement>
    {
        [SerializeField] public GameObject damageUi;
        [SerializeField] public Slider damageProgress;
        [SerializeField] public TMP_Text damagePercent;
        [SerializeField] public Animation damageNotiAnimation;
        
        private int damageCounter = 0;
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
            if (damageCounter == 10)
            {
                // damageUi.SetActive(true);
                // StartCoroutine(ShowUI());
                damageNotiAnimation.Play();
            }
        }

        // private IEnumerator ShowUI()
        // {
        //     yield return waitTimes;
        //     damageUi.SetActive(false);
        // }

        public void Update()
        {
            float damageValue = (float)damageCounter/10;
            
            if (damageCounter >= 100)
            {
                damagePercent.text = "100%";
                damageProgress.value = 1;
            }
            else
            {
                damagePercent.text = (damageCounter*10 + "%");
                damageProgress.value = damageValue;
            }
        }
    }
}



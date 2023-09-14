using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using PhEngine.Core;

namespace SuperGame
{
    public class JumpAchievement : Singleton<JumpAchievement>
    {
        [SerializeField] public GameObject Eui;
        [SerializeField] public Slider jumpProgress;
        [SerializeField] public TMP_Text jumpPercent;
        [SerializeField] public Animation jumpNotiAnimation;
        
        private int eCounter = 0;
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
            if (eCounter == 10)
            {
                // Eui.SetActive(true);
                // StartCoroutine(ShowUI());
                jumpNotiAnimation.Play();
            }
        }

        // private IEnumerator ShowUI()
        // {
        //     yield return waitTimes;
        //     Eui.SetActive(false);
        // }

        public void Update()
        {
            float jumpValue = (float)eCounter/10;
            
            if (eCounter >= 100)
            {
                jumpPercent.text = "100%";
                jumpProgress.value = 1;
            }
            else
            {
                jumpPercent.text = (eCounter*10 + "%");
                jumpProgress.value = jumpValue;
            }
        }
    }
}

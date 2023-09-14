using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;
using PhEngine.Core;

namespace SuperGame
{
    public class Victory : Singleton<Victory>
    {
        [SerializeField] public GameObject winUi;
        [SerializeField] public Slider winProgress;
        [SerializeField] public TMP_Text winPercent;
        [SerializeField] public Animation winNotiAnimation;

        private int winCounter = 0;
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
            if (winCounter == 10)
            {
                // winUi.SetActive(true);
                // StartCoroutine(ShowUI());
                winNotiAnimation.Play();
            }
        }

        // private IEnumerator ShowUI()
        // {
        //     yield return waitTimes;
        //     winUi.SetActive(false);
        // }

        public void Update()
        {
            float winValue = (float)winCounter/10;

            if (winCounter >= 100)
            {
                winPercent.text = "100%";
                winProgress.value = 1;
            }
            else
            {
                winPercent.text = (winCounter*10 + "%");
                winProgress.value = winValue;
            }
        }
    }
}


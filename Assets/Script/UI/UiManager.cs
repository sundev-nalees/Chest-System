using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ChestSystem
{
    public class UiManager : MonoBehaviour
    {
        [Header("Resorces")]
        [SerializeField] private TextMeshProUGUI gemCountText;
        [SerializeField] private TextMeshProUGUI coinCountText;
        [SerializeField] private int gemIntialCount;
        [SerializeField] private int coinIntialCount;
        [SerializeField] private int maxGem;
        [SerializeField] private int maxCoin;
        private int coinCount;
        private int gemCount;
        void Start()
        {
            AddCoinCount(coinIntialCount);
            AddGemCount(gemIntialCount);
        
        }

        public bool AddCoinCount(int amount)
        {
            if (coinCount + amount <= maxCoin)
            {
                coinCount += amount;
                if (coinCountText)
                {
                    coinCountText.text = coinCount.ToString();
                }
                return true;
            }
            return false;
        }

        public bool AddGemCount(int amount)
        {
            if (gemCount + amount <= maxGem)
            {
                gemCount += amount;
                if (gemCountText)
                {
                    gemCountText.text = gemCount.ToString();
                }
                return true;
            }
            return false;
        }

        public void OnCreateButtonPressed()
        {
            Debug.Log("1");
            ChestService chestService = ChestService.Instance;
            if (chestService)
            {
                chestService.SpawnChest();
               
            }
        }
    }
}

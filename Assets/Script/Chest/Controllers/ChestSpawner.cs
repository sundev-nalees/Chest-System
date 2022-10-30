using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestSpawner : MonoBehaviour
    {
        [SerializeField] private ChestScriptable chestConfiguration;
        [SerializeField] private float timeToskipFor1Gem;
        private ChestSlotsController chestSlotsController;

        private void Start()
        {
            chestSlotsController = ChestService.Instance.GetChestSlotsController;
        }
        public void SpawnChest(ChestType chestType)
        {
            ChestConfig config = chestConfiguration.ChestList.Find(item => item.chestType == chestType);
            if (chestSlotsController)
            {
                chestSlotsController.SpawnChest(config);
            }
        }

        public void SpawnChest()
        {
            int index = Random.Range(0, chestConfiguration.ChestList.Count);
            if (chestSlotsController)
            {
                chestSlotsController.SpawnChest(chestConfiguration.ChestList[index]);
            }

        }
        public float GetTimeToSkipFor1Gem { get { return timeToskipFor1Gem; } }
    }
}

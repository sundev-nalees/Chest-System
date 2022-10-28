using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestSpawner : MonoBehaviour
    {
        [SerializeField] ChestScriptable chestScriptable;
        [SerializeField] private float timeToSkipFor1Gem;
        [SerializeField] GameObject prefab;

        private void Start()
        {

        
        }

        public void SpawnChest()
        {
            Instantiate(prefab,transform);
            
        }
    }
}

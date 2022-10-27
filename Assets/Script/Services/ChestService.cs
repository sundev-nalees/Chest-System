using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestService : MonoSingletonGeneric<ChestService>
    {
        [SerializeField] private ChestSpawner chestSpawner;
        
        public void SpawnChest()
        {
            chestSpawner.SpawnChest();
            Debug.Log("2");
        }
    }
}

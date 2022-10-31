using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem.Chest.SO
{
    [CreateAssetMenu(fileName ="ChestList",menuName ="ScriptableObjects/ChestSystem/ChestList")]
    public class ChestScriptable : ScriptableObject
    {
        public List<ChestConfig> ChestList;
    }
}

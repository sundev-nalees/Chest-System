using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    [CreateAssetMenu(fileName ="ChestList",menuName ="ScriptableObjects/ChestSystem/ChestList")]
    public class ChestScriptable : ScriptableObject
    {
        public List<ChestConfig> ChestList;
    }
}

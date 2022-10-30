using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace ChestSystem
{
    public class ChestView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private string unlockPopUpTitle;
        [SerializeField] private string unlockedPopUpTitle = "CONGRATULATIONS";
        [SerializeField] private Button unlockButton;

        [SerializeField] private string spawnPopUpTitle = "CONGRATULATIONS";
        private ChestController chestcontroller;

        private void Start()
        {
            chestcontroller.Start();
            unlockButton.onClick.AddListener(OnUnlockClicked);
        }

        private void Update()
        {
            chestcontroller.Update();

        }

        public void SetTimerText(string text)
        {
            timerText.text = text;
        }

        public void OnUnlockClicked()
        {
            chestcontroller.OnUnlockClicked(unlockPopUpTitle);
        }

        public void SetChestController(ChestController _controller)
        {
            chestcontroller = _controller;
        }

        public string GetChestUnlockedTitle { get { return unlockedPopUpTitle; } }

        public string GetSpawnPopupTitle { get { return spawnPopUpTitle; } }
    }
}
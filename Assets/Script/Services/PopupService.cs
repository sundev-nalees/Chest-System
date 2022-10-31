using System;
using System.Collections.Generic;
using UnityEngine;
using ChestSystem.UI;
using Singleton;

namespace ChestSystem.Services
{
    public class PopupService : MonoSingletonGeneric<PopupService>
    {
        [SerializeField] private PopupManager popupManager;

        private bool isShowing;
        private ChestService chestService;
        private Queue<Action> popUpQueue = new Queue<Action>();

        private void Start()
        {
            chestService = ChestService.Instance;
        }
        private void Update()
        {
            if (!isShowing && popUpQueue.Count != 0)
            {
                isShowing = true;
                Action action = popUpQueue.Dequeue();
                action();
            }
        }
        public void QueuePopup(ChestUnlockMsg msgObject)
        {
            Action action = new Action(() => ShowNewUnlockMsg(msgObject));
            popUpQueue.Enqueue(action);
        }

        public void QueuePopup(Message message)
        {
            Action action = new Action(() => ShowMessage(message));
            popUpQueue.Enqueue(action);
        }

        public void QueuePopup(MsgPopupType msgType)
        {
            Action action = new Action(() => ShowMessage(msgType));
            popUpQueue.Enqueue(action);
        }
        private void ShowMessage(Message message)
        {
            popupManager.ShowMessage(message);
        }
        private void ShowNewUnlockMsg(ChestUnlockMsg msgObject)
        {
            popupManager.ChestUnlockPopup(msgObject);
        }

        private void ShowMessage(MsgPopupType msgType)
        {
            popupManager.ShowMessage(msgType);
        }
        public int CurrentUnlockingChestID { get { return chestService.CurrentUnlockingChestId; } }


        public bool SetIsShowing { set { isShowing = value; } }
    }
}

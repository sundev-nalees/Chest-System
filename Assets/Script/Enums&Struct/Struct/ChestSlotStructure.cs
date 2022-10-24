using ChestSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ChestSlot
{
    public int chestSlotID;
    public ChestSlotController chestSlotController;

    public ChestSlot(int id,ChestSlotController controller)
    {
        this.chestSlotID = id;
        this.chestSlotController = controller;
    }
}

﻿using System;

namespace InventoryTest.Logic.Abstract
{
    public interface IInventory
    {
        int Capacity { get; set; }
        bool IsFull { get; }

        int GetItemAmount(Type itemType);
        IInventoryItem GetItem(Type itemType);
        IInventoryItem[] GetAllItems();
        IInventoryItem[] GetAllItems(Type itemType);
        IInventoryItem[] GetEquippedItems();

        bool TryToAdd(object sender, IInventoryItem item);
        void Remove(object sender, Type itemType, int amount = 1);
        bool HasItem(Type type, out IInventoryItem item);
    }
}
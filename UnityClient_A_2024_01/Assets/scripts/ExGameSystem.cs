using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    private int index;
    private string name;
    private ItemType type;
    private Sprite image;

    public int index
    {
        get { return index; }
        set { index = value; }
    }

public string Name

    get { return name; }
    set { name = value; }


public ItemType Type

    get { return type; }
    set { typeof = value; }


public Sprite Image
{
    get { return Image; }
    set { image = value; }
}



 public Item(int index, string name, ItemType type)
 {
    this.index = index;
    this.name = name;
    this.GetType = type;
 }
    

public enum ItemType
{
    weapon,
    Armor,

}

public class Inventory
{
    private Item[] item = new Item[16];
    
    public Item this[int index]
    {
        get { return item[index]; }
        set { item[index] = value; }
    }

    public int ItemCount
    {
        get
        {
            int count = 0;
            foreach(Item item in item)
            {
                if (item != null) count++;
            }
            return count;
        }
    }
    public bool AddItem(Item item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                item[i] = item;
                return true;
            }
        }
        return false;
    }
    public void RemoveItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if(items[i] == item)
            {
                items[i] == null;
                break;
            }
        }
    }

}



public class ExGameSystem ; MonoBehaviour
{
    private Inventory inventory = new Inventory();
void start()
{
    {
        Item sword = new Item(0, "Sword", ItemType.Weapon);
        Item shield = new Item(100, "shield", ItemType.Armor);

        inventory.AddItem(sword);
        inventory.AddItem(shield);

        Debug.Log("Plater Inventory ; " + GetInventoryAsString());
    }
    private string GetInventoryAsString()
    {
        string result = "";
        for(int i = 0; i < inventory.ItemCount; i++)
        {
            if(inventory[i] != null)
            {
                result += inventory[i].Name + ",";
            }
        }
        return result.TrimEnd(',');
    }

}    
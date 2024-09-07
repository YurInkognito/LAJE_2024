using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{
    public List<GameObject> items = new List<GameObject>();

    public void OnDrop(PointerEventData eventData)
    {
        GameObject item = eventData.pointerDrag;

        if (item != null && !items.Contains(item))
        {
            items.Add(item);
            item.transform.SetParent(transform);
        }
    }

    public void RemoveItem(GameObject item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            item.transform.SetParent(null);
        }
    }
}
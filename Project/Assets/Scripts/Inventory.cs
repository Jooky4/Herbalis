using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{

    [SerializeField]
    private Image[] Slots = new Image[3];
    private Sprite sprite;



    public bool PutInventory(GameObject gameObject)
    {
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;

        for (int index = 0; index < Slots.Length; index++)
        {
            if (Slots[index].GetComponent<Image>().sprite == null)
            {
                Slots[index].GetComponent<Image>().sprite = sprite;
                break;
            }
        }
        Destroy(gameObject, 0.1f);

        return false;
    }

}

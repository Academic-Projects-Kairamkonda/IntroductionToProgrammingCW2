using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IPG_CW2
{
    public class InventoryData : MonoBehaviour
    {
        public GameObject pickUpItemsMenu;
        public Transform keysMenu;

        public Sprite[] keys = new Sprite[4];
        public GameObject[] keyObjects = new GameObject[2];

        private readonly int count = 0;

        public void AddItem(string itemPick)
        {
            switch (itemPick)
            {
                case "Golden Key":
                pickUpItemsMenu.transform.GetChild(0).GetComponent<Image>().sprite = keys[0];
                    break;

                case "Bronze Key":
                    pickUpItemsMenu.transform.GetChild(1).GetComponent<Image>().sprite = keys[1];
                    break;

                default:
                    Debug.LogError("String not found");
                    break;

            }
        }

        /// <summary>
        /// Functiion to spanwn golden key
        /// </summary>
        public void SpawnGoldenkey()
        {
            int index = 0;
            if (pickUpItemsMenu.transform.GetChild(index).GetComponent<Image>().sprite != null)
            {
                GameObject temp=Instantiate(keyObjects[index]);
                temp.GetComponent<PickupItem>().inventoryData = this;
                temp.GetComponent<PickupItem>().itemMenu = pickUpItemsMenu;
                temp.gameObject.transform.SetParent(keysMenu);
                temp.gameObject.name = "Golden Key";

                pickUpItemsMenu.transform.GetChild(index).GetComponent<Image>().sprite = null;
            }
        }

        /// <summary>
        /// Function too brownkey
        /// </summary>
        public void SpawnBrownKey()
        {
            int index = 1;
            if (pickUpItemsMenu.transform.GetChild(index).GetComponent<Image>().sprite != null)
            {
                GameObject temp = Instantiate(keyObjects[index]);
                temp.GetComponent<PickupItem>().inventoryData = this;
                temp.GetComponent<PickupItem>().itemMenu = pickUpItemsMenu;
                temp.gameObject.transform.SetParent(keysMenu);
                temp.gameObject.name = "Bronze Key";

                pickUpItemsMenu.transform.GetChild(index).GetComponent<Image>().sprite = null;
            }
        }
    }
}

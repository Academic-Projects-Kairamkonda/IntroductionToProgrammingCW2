using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IPG_CW2
{
    public class PickupItem : MonoBehaviour,IBeginDragHandler
    {
        Rigidbody rb;

        public InventoryData inventoryData;

        public GameObject itemMenu;

        private void Awake()
        {
            rb = this.GetComponent<Rigidbody>();
            //itemMenu.SetActive(false);
        }

        /*
        private void OnMouseDrag()
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x,
                                         Input.mousePosition.y,
                                         -Camera.main.transform.position.z + transform.position.z);

            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = objPos;

            itemMenu.SetActive(true);

            rb.isKinematic = true;
        }


        private void OnMouseUp()
        {
            rb.isKinematic = false;
            StartCoroutine("ClosePanel");
        }

        IEnumerator ClosePanel()
        {
            itemMenu.GetComponent<Animation>().Play("PickupItemMenuClose");
            yield return new WaitForSeconds(2f);
            itemMenu.SetActive(false);
            StopCoroutine("ClosePanel");
        }

        */

        public void OnBeginDrag(PointerEventData pointerEventData)
        {
            Debug.Log("Drag Started");
        }

        /// <summary>
        /// Destroys the gameObject add it to inventory
        /// </summary>
        private void OnMouseDown()
        {
            Destroy(this.gameObject, 0.2f);

            Debug.Log(this.gameObject.name);

            inventoryData.AddItem(this.gameObject.name);
            
        }
    }
}
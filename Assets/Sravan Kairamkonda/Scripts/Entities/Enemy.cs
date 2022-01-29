using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Enemy : MonoBehaviour
    {
        public Transform target;

        private float speed;

        public GameObject ammo;
        public Transform ammoParent;

        void Update()
        {
            speed = 2f;
            speed *= Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);

            var dir = target.position - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                this.GetComponent<AudioSource>().Play();
                GameObject temp= Instantiate(ammo,transform.position,Quaternion.identity);
                temp.transform.SetParent(ammoParent);
               
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

            if (collision.gameObject.tag=="Enemy")
            {
                this.GetComponent<AudioSource>().Play();
                Destroy(collision.gameObject, 0.5f);
            }
        }
    }
}
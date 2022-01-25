using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Enemy : MonoBehaviour
    {
        public Transform target;
        private float speed;

        void Update()
        {
            speed = 2f;
            speed *= Time.deltaTime;
            transform.position=Vector3.MoveTowards(transform.position, target.transform.position,speed);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Range : MonoBehaviour
    {
        public GameManager GameManager;

        public GameObject bullet;

        private LineRenderer lineRenderer;

        private void Awake()
        {
            lineRenderer = this.transform.GetChild(0).GetComponent<LineRenderer>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision != null)
            {
                lineRenderer.material.color = Color.red;
            }

            GameManager.shootController.InstantiateBullet(bullet, collision.transform);
            GameManager.player.RotatePlayer(collision.transform);
        }
    }
}
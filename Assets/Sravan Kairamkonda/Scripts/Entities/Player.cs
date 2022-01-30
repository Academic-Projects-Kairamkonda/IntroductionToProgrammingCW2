using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Player : MonoBehaviour
    {
        #region Members

        /// <summary>
        /// Get the current rotation value.
        /// </summary>
        public SliderRotationValue silderRotationValue;

        /// <summary>
        /// Stores the value of the slider.
        /// </summary>
        float tiltAngle;

        /// <summary>
        /// boolean to rotate with mouseeInput
        /// </summary>
        public bool autoRotate;

        /// <summary>
        /// Rotate the player on mosue Input
        /// </summary>
        public bool mouseInput;

        #endregion Members

        #region Unity Methods

        /// <summary>
        /// reset the everthing to default values
        /// </summary>
        private void Start()
        {
            DefaultPlayerValues();
        }

        /// <summary>
        /// Player movement with the input
        /// </summary>
        void Update()
        {
            RotatePlayer();

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * Time.deltaTime * 5f);
            }

        }

        #endregion Unity functions

        #region Methods

        /// <summary>
        /// This function mainly used to reset values of player before the game starts.
        /// </summary>
        private void DefaultPlayerValues()
        {
            //Cursor.lockState = CursorLockMode.Locked;

            transform.localEulerAngles = Vector3.zero;
            autoRotate = false;
            //mouseInput = false;
        }

        /// <summary>
        /// Rotates the player on "z-axis".
        /// </summary>
        private void RotatePlayer()
        {

            if (silderRotationValue.AngleValue == 0)
            {
                tiltAngle = 90f * Time.deltaTime;
            }
            else
            {
                tiltAngle = silderRotationValue.AngleValue * Time.deltaTime;
            }


            if (mouseInput)
            {
                // Smoothly tilts a transform towards a target rotation.
                float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle;

                transform.Rotate(0, 0, tiltAroundZ);

            }

            else if(autoRotate)
            {
                transform.Rotate(0, 0, tiltAngle);
            }
        }

        /// <summary>
        /// UnLockMode is used to change the angle whenever needed.
        /// </summary>
        public void MouseUnLockMode()
        {
             Cursor.lockState = CursorLockMode.None;
        }

        /// <summary>
        /// Lockmode when the game is playing
        /// </summary>
        public void MouseLocked()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        /// <summary>
        /// Rotate the player when anything is in the range
        /// </summary>
        /// <param name="transform"></param>
        public void RotatePlayer(Transform transform)
        {
            this.transform.localEulerAngles=transform.localEulerAngles;
        }

        #endregion Methods
    }
}
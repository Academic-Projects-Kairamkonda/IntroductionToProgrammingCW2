using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    /// <summary>
    /// This class represents player rotation 
    /// </summary>
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
        public bool mouseInput;

        #endregion Members

        #region Unity Methods

        private void Start()
        {
            DefaultPlayerValues();
        }

        void Update()
        {
            RotatePlayer();
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
            mouseInput = false;
        }

        /// <summary>
        /// Rotates the player on "z-axis".
        /// </summary>
        private void RotatePlayer()
        {
            tiltAngle = silderRotationValue.AngleValue * Time.deltaTime;

            if (mouseInput)
            {
                // Smoothly tilts a transform towards a target rotation.
                float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle;

                transform.Rotate(0, 0, tiltAroundZ);
            }
            else
            {
                transform.Rotate(0, 0, tiltAngle);
            }
        }

        /// <summary>
        /// UnLockMode is used to change the angle whenever needed.
        /// </summary>
        private void MouseUnLockMode()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
            }

            if (Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        #endregion Methods
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace IPG_CW2
{
    /// <summary>
    /// The class deals with the rotation value on text object
    /// </summary>
    public class SliderRotationValue : MonoBehaviour
    {
        #region Members

        /// <summary>
        /// Text component of the slider value.
        /// </summary>
        [SerializeField] private TextMeshProUGUI angleText;

        /// <summary>
        /// slider to store the value from the inspector.
        /// </summary>
        private float angleValue;

        /// <summary>
        /// property of slider value which only get by another values.
        /// </summary>
        public float AngleValue
        {
            get { return angleValue; }
            set { if(AngleValue>=0) angleValue = value; }
        }

        #endregion Members 

        #region Unity Methods

        private void Awake()
        {
            AngleValue = this.GetComponent<Slider>().value;
            
        }

        private void Update()
        {
            this.GetComponent<Slider>().value = AngleValue;
            angleText.text = AngleValue.ToString();
        }


        #endregion Unity Methods

        #region Methods

        /// <summary>
        /// Changes in the slider value.
        /// </summary>
        private void SliderValueChanged()
        {
            
        }

        /// <summary>
        /// Default values of the game.
        /// </summary>
        private void DefaultSilderRotationValue()
        {
            
        }

        /// <summary>
        /// Decreases the angle with respective to Time.delatime
        /// </summary>

        private void DecrementAngle()
        {
          
        }


        #endregion Methods
    }
}
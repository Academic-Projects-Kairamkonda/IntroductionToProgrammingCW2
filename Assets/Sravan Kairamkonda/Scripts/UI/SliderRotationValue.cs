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
        }

        #endregion Members 

        #region Unity Methods

        void Start()
        {
            DefaultSilderRotationValue();
        }

        void Update()
        {
            SliderValueChanged();
        }

        #endregion Unity Methods

        #region Methods

        /// <summary>
        /// Changes in the slider value.
        /// </summary>
        private void SliderValueChanged()
        {
            angleValue = this.GetComponent<Slider>().value;
            angleText.text = angleValue.ToString();
        }

        /// <summary>
        /// Default values of the game.
        /// </summary>
        private void DefaultSilderRotationValue()
        {
            angleText.text = 0.ToString();
        }

        #endregion Methods
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderRotationValue : MonoBehaviour
{
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

    #region Unity functions

    void Start()
    {
        DefaultSilderRotationValue();
    }

    void Update()
    {
        angleValue = this.GetComponent<Slider>().value;
        angleText.text = angleValue.ToString();
    }

    #endregion Unity functions

    /// <summary>
    /// Changes in the slider value.
    /// </summary>
    private void SliderValueChanged()
    {
        angleText.text= angleValue.ToString();
    }

    /// <summary>
    /// Default values of the game.
    /// </summary>
    private void DefaultSilderRotationValue()
    {
        angleText.text=0.ToString();
    }
}

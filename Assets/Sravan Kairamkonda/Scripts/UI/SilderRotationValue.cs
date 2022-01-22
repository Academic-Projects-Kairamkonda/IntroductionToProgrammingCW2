using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SilderRotationValue : MonoBehaviour
{
    /// <summary>
    /// Text component of the slider value.
    /// </summary>
    [SerializeField] private TextMeshProUGUI angleValue;
   
    /// <summary>
    /// slider to store the value from the inspector.
    /// </summary>
    private float sliderValue;

    /// <summary>
    /// property of slider value which only get by another values.
    /// </summary>
    public float SliderValue
    {
        get { return sliderValue; }
    }

    #region Unity functions

    void Awake()
    {
        sliderValue = this.GetComponent<Slider>().value;
    }

    void Start()
    {
        DefaultSilderRotationValue();
    }

    void Update()
    {
        SliderValueChanged();
    }

    #endregion Unity functions

    /// <summary>
    /// Changes in the slider value.
    /// </summary>
    private void SliderValueChanged()
    {
        angleValue.text= sliderValue.ToString();
    }

    /// <summary>
    /// Default values of the game.
    /// </summary>
    private void DefaultSilderRotationValue()
    {
        angleValue.text=0.ToString();
    }
}

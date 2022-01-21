using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SilderRotationValue : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI angleValue;
    private float sliderValue;

    public float SliderValue
    {
        get { return sliderValue; }
    }


    void Awake()
    {
        sliderValue = this.GetComponent<Slider>().value;
    }

    void Start()
    {
        SliderUpdateAngle();
    }


    void Update()
    {
        SliderValueChanged();
    }

    private void SliderValueChanged()
    {
        sliderValue = this.GetComponent<Slider>().value;

        angleValue.text= sliderValue.ToString();
    }

    private void SliderUpdateAngle()
    {
        angleValue.text=0.ToString();
    }
}

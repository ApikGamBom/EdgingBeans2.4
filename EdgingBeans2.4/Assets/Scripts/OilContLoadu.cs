using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class OilContLoadu : MonoBehaviour
{
    
    [SerializeField] private TMP_Text countText;
    [SerializeField] private float maxOil = 50f;
    [SerializeField] private Slider ShowSlider;
    public float oilAmount = 5f;


    void Start()
    {
        countText.text = oilAmount.ToString() + "/" + maxOil;
        ShowSlider.value = oilAmount / maxOil;
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = oilAmount.ToString() + "/" + maxOil;
        ShowSlider.value = oilAmount / maxOil;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Halves : MonoBehaviour
{
    public Slider cakeFraction;
    public Button serve;
    public float val;
    public GameObject correct;
    public GameObject tryAgain;
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = serve.GetComponent<Button>();
        btn.onClick.AddListener(SubmitSliderSetting);
        val = 0;
    }

    // invoked when a submit button is clicked
    public void SubmitSliderSetting()
    {
        // displays the value of the slider in the console
        Debug.Log(cakeFraction.value);
        val = cakeFraction.value;

        // for halves
        if(val > .3 && val < .6)
        {
            correct.SetActive(true);
        } else
        {
            tryAgain.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
    public Button wrong;
    
    // Start is called before the first frame update
    void Start()
    {
        Button correct_btn = serve.GetComponent<Button>();
        correct_btn.onClick.AddListener(SubmitSliderSetting);
        val = 0;

        Button wrong_btn = wrong.GetComponent<Button>();
        wrong_btn.onClick.AddListener(WrongAnswer);
        //wrong.OnClick.AddListener(WrongAnswer);

        cakeFraction.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // when try again button is clicked
    public void WrongAnswer()
    {
        tryAgain.SetActive(false);
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

    public void ValueChangeCheck()
    {
        correct.SetActive(false);
        tryAgain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if slider value is changed, reset
        
    }
}

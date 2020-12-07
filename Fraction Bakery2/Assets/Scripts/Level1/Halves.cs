using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Halves : MonoBehaviour
{
    public Slider cakeFraction;
    public Button serve;
    
    // invoked when a submit button is clicked
    public void SubmitSliderSetting()
    {
        // displays the value of the slider in the console
        Debug.Log(cakeFraction.value);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = serve.GetComponent<Button>();
        btn.onClick.AddListener(SubmitSliderSetting);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

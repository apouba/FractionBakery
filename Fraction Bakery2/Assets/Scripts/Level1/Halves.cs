using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Halves : MonoBehaviour
{
    public Slider cakeFraction;
    public Button serve;
    public Button next;
    public Button wrong;

    public float val;

    public GameObject correct1;
    public GameObject correct2;
    public GameObject correct3;
    public GameObject correct4;
    public GameObject correct5;
    public GameObject tryAgain;
    public GameObject group1;
    public GameObject group2;
    public GameObject group3;
    public GameObject group4;
    public GameObject group5;
    public GameObject endscreen;
    public GameObject nextButtonView;


    // Start is called before the first frame update
    void Start()
    {
        // submit fraction button
        Button submit_btn = serve.GetComponent<Button>();
        submit_btn.onClick.AddListener(SubmitSliderSetting);
        val = 0;

        // try again button
        Button wrong_btn = wrong.GetComponent<Button>();
        wrong_btn.onClick.AddListener(WrongAnswer);
        //wrong.OnClick.AddListener(WrongAnswer);

        // next group button
        Button next_btn = next.GetComponent<Button>();
        next_btn.onClick.AddListener(NextGroup);

        // if slider is moved
        cakeFraction.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

       // every group if correct and finished


    }

    // next group of people out of 5
    public void NextGroup()
    {
        if(group1.activeSelf)
        {
            group1.SetActive(false);
            group2.SetActive(true);
            correct1.SetActive(false);
            nextButtonView.SetActive(false);
        } else if(group2.activeSelf)
        {
            Debug.Log("group2");
            group2.SetActive(false);
            group3.SetActive(true);
            correct2.SetActive(false);
            nextButtonView.SetActive(false);
        } else if(group3.activeSelf)
        {
            group3.SetActive(false);
            group4.SetActive(true);
            correct3.SetActive(false);
            nextButtonView.SetActive(false);
        } else if(group4.activeSelf)
        {
            group4.SetActive(false);
            group5.SetActive(true);
            correct4.SetActive(false);
            nextButtonView.SetActive(false);
        } else
        {
            endscreen.SetActive(true);
        }
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

        
        if(group1.activeSelf) // for halves
        {
            if (val > .4 && val < .6)
            {
                correct1.SetActive(true);
                nextButtonView.SetActive(true);
            }
            else
            {
                tryAgain.SetActive(true);
            }
        } else if(group2.activeSelf) // for 1
        {
            if (val > .9)
            {
                correct2.SetActive(true);
                nextButtonView.SetActive(true);
            }
            else
            {
                tryAgain.SetActive(true);
            }
        } else if (group3.activeSelf) // for 1/3
        {
            if (val > .2 && val < .4)
            {
                correct3.SetActive(true);
                nextButtonView.SetActive(true);
            }
            else
            {
                tryAgain.SetActive(true);
            }
        } else if (group4.activeSelf) // for 1/4
        {
            if (val > .15 && val < .35)
            {
                correct4.SetActive(true);
                nextButtonView.SetActive(true);
            }
            else
            {
                tryAgain.SetActive(true);
            }
        } else if (group5.activeSelf) // for 1/2
        {
            if (val > .3 && val < .6)
            {
                correct5.SetActive(true);
                nextButtonView.SetActive(true);
            }
            else
            {
                tryAgain.SetActive(true);
            }
        }

    }

    public void ValueChangeCheck()
    {
        //correct.SetActive(false);
        tryAgain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if slider value is changed, reset
        
    }
}

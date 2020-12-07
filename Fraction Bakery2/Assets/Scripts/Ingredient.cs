using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows;

public class Ingredient : MonoBehaviour
{
    public Button button;
    bool correct = true;
    public Slider flour;
    public Slider sugar;
    public Slider milk;
    public Text status;

    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(AnswerSubmit);
    }

    private void AnswerSubmit()
    {
        if(flour.value > 0.60 || flour.value < 0.40)
        {
            Debug.Log("flour is not correct");
            Debug.Log(flour.value);
            correct = false;
        }
        if(sugar.value > 0.35 || sugar.value < 0.15)
        {
            Debug.Log("sugar is not correct");
            Debug.Log(sugar.value);
            correct = false;
        }
        if(milk.value > 0.85 || milk.value < 0.65)
        {
            Debug.Log("milk is not correct");
            Debug.Log(milk.value);
            correct = false;
        }
        if(correct)
        {
            Debug.Log("Congrats you did it!");
            status.text = "Congratulations! you did it!";
        }
        else
        {
            status.text = "Not quite! Try again, you go it!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

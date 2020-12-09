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
    public float flourRecipe;
    public float sugarRecipe;
    public float milkRecipe;

    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(AnswerSubmit);
    }

    private void AnswerSubmit()
    {
        string incorrectText = "";
        if(flour.value > (flourRecipe+0.1) || flour.value < (flourRecipe-0.1))
        {
            incorrectText += "flour is not correct\n";
            Debug.Log(flour.value);
            correct = false;
        }
        if(sugar.value > (sugarRecipe + 0.1) || sugar.value < (sugarRecipe - 0.1))
        {
            incorrectText += "sugar is not correct\n";
            Debug.Log(sugar.value);
            correct = false;
        }
        if(milk.value > (milkRecipe + 0.1) || milk.value < (milkRecipe - 0.1))
        {
            incorrectText += "milk is not correct\n";
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
            status.text = incorrectText;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

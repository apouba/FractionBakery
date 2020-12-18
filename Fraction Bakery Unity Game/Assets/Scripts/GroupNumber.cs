using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupNumber : MonoBehaviour
{
    public Text changingText;
    public int group;
    
    
    // Start is called before the first frame update
    void Start()
    {
        group = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // when something happens like pressing a button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("text");
            changingText.text = group + "/5";
        }
    }

    public void TextChange()
    {
        changingText.text = "2";
    }
}

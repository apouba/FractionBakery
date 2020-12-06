using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    public Button button;
    public GameObject instructions;
    public GameObject playButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
        
    }

    void TaskOnClick()
    {
        
        Debug.Log("clicked");
        instructions.SetActive(false);
        playButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

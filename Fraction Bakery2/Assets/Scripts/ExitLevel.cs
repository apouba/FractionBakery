using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour
{

    // if exit level button is pressed, send back to level map
    public Button exit;

    // Start is called before the first frame update
    void Start()
    {
        Button exit_btn = exit.GetComponent<Button>();
        exit_btn.onClick.AddListener(BackToMap);
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Levels Map");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

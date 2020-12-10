using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour
{
    public string levelName;
    private GameObject player;
    private Pin pin;
    
    private Vector2 player_location;
    public Vector2 pin_location;
    // get location of player and pin they are supposed to be on

    // if exit level button is pressed, send back to level map
    public Button exit;

    // Start is called before the first frame update
    void Start()
    {
        //player_location = new Vector2(0, 0);
        //pin_location = new Vector2(0, 0);

        player = GameObject.FindWithTag("Player");
        //player_location = player.transform.position;
        pin = 
        

        Button exit_btn = exit.GetComponent<Button>();
        exit_btn.onClick.AddListener(BackToMap);
    }

    public void BackToMap()
    {

        //player.transform.position = pin.transform.position; 
        Player ps = player.GetComponent<Player>();
        ps.SetCurrentPin(pin); 
        //player.get(CurrentPin) = pin;
        SceneManager.LoadScene("Levels Map");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

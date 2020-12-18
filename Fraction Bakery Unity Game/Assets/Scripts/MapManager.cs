using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    public Player Player;
    public Pin StartPin;
    //public Text SelectedLevelText;
    
    // Start is called before the first frame update
    void Start()
    {
        Player.Initialise(this, StartPin);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.IsMoving) return;

        CheckForInput();
    }

    // check if the player has pressed a button
    private void CheckForInput()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Player.TrySetDirection(Direction.Up);
        } else if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            Player.TrySetDirection(Direction.Down);
        }

    }

    // Update the GUI Text
    //public void UpdateGui()
    //{
        //SelectedLevelText.text = string.Format("Current Level: {0}", Player.CurrentPin.SceneToLoad);
    //}
}

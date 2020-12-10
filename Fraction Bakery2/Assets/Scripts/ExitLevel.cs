using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour
{
    public string levelName;
    private GameObject player;
    public GameObject pin;
    public Pin p1;
    
    // get location of player and pin they are supposed to be on

    // if exit level button is pressed, send back to level map
    public Button exit;

    // Start is called before the first frame update
    void Start()
    {
        Transform meeple;
        player = GameObject.FindWithTag("Player");

        Scene scene1 = SceneManager.GetSceneByName("Levels Map");

        List<GameObject> rootObjects = new List<GameObject>();
        scene1.GetRootGameObjects(rootObjects);

        for (int i = 0; i < rootObjects.Count; i++)
        {
            if(rootObjects[i] == GameObject.Find("Pins"))
            {
                meeple = (rootObjects[i].transform.GetChild(0));
                pin = meeple.gameObject;
                p1 = pin.GetComponent<Pin>();

            }
        }
        
        //p1 = Pins.transform.Find("1 - elementary medium");
        //Pin p1 = pin.GetComponent<Pin>();
        //Pin p1 = pin.GetComponent<Pin>();
        //Debug.Log(p1.GetType().ToString());
        //pin = p1.transform.Find("pin1").GetComponent<Pin>();

        Button exit_btn = exit.GetComponent<Button>();
        exit_btn.onClick.AddListener(BackToMap);
    }

    public void BackToMap()
    {

        //player.transform.position = pin.transform.position; 
        Player ps = player.GetComponent<Player>();
        
        ps.SetCurrentPin(p1); 
        //player.get(CurrentPin) = pin;
        SceneManager.LoadScene("Levels Map");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

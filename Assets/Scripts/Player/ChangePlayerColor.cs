using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerColor : MonoBehaviour
{
    public Player player;
    public Dropdown myDropDown;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(myDropDown.value)
        {
            case 0:
                player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                player.GetComponent<Renderer>().material.color = Color.green;
                break;

        }
    }
}

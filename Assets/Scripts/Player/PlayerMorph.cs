using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMorph : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("e"))
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        if (Input.GetKeyDown("q"))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
}

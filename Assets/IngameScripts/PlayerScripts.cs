using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScripts : GameStatePattanScripts
{
    private int Speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,Speed*Time.deltaTime);
        }
        
        /*if(Input.GetKey(KeyCode.LeftArrow))
        {
             transform.Translate(0,0,-Speed);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0,0,Speed);
        }
        */
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-Speed*Time.deltaTime);
        }

    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "game")
        {
            Debug.Log("HeloWord!!");
            StatePattin = 2;
        }
    }

}

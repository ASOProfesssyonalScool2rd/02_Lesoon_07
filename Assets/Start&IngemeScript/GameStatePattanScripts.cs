using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStatePattanScripts : MonoBehaviour
{
    public bool State; 
    protected GameObject Sphere = null;
    public int StatePattin = 0;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        switch (StatePattin)
        {
            case 0:
                if(Input.GetMouseButtonDown(0))
                {
                    StatePattin = 1;
                }
                break;
        }
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("PushLeftMouseButton!!");
            Sphere.SetActive(true);
        }
       if(Input.GetKey(KeyCode.Escape))
       {
           State = true;
       }

       if (State)
       {
           Sphere.SetActive(true);
       }
       else
       {
         Sphere.SetActive(false);   
       }

    }
    
}


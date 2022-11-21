using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStatePattanScripts : MonoBehaviour
{
    
    public GameObject Sphere = null;
    public static int StatePattin = 0;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(StatePattin);
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("PushLeftMouseButton!!");
            StatePattin = 1;
        }
        /*if(Input.GetKey(KeyCode.Escape))
       {
           State = true;
       }
       */

       if (StatePattin == 2)
       {
           Debug.Log("これは動作しました");
           Sphere.SetActive(true);
       }
       else
       {
         Sphere.SetActive(false);   
       }

    }
    
}


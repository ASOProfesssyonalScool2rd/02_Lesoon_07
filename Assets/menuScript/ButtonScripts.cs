using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
   public void Rezalt()
   {
      SceneManager.LoadScene("InGame");
   }
   public void Exit()
   {
     Application.Quit();
     Debug.Log("HeloWord!!");
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
          SceneManager.LoadScene("menu"); //Escを押すとメニュー画面へ。
        }
    }
    public void PushEnd()
    {
         SceneManager.LoadScene("Title"); //終了ボタンを押すと、タイトル画面へ。
         Debug.Log("HeloWord!!");
    }
    public void PushBack()
    {
        SceneManager.LoadScene("Ingame"); //戻るボタンを押すと、もう1回最初からゲーム画面が動き出す
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Notification : MonoBehaviour
{
    [SerializeField] Canvas canvas;
   // [SerializeField] NotificationPanel notificationPanelPrefab;
    //NotificationPanel currentPanel;
 
    [SerializeField] List<string> texts;
    bool IsWaiting;
 
    static Notification instance;
 
    // インスタンスを取得
    public static Notification GetInstance()
    {
        return instance;
    }
 
    private void Awake()
    {
        instance = this;
        texts = new List<string>();
    }
 
    // テキストをリストに入れてポップアップを表示
    public void PutInQueue(string text)
    {
        texts.Add(text);
        StartNext();
    }
 
    void StartNext()
    { 
        // 待機中でなくてテキストが残っていれば
         if(!IsWaiting && texts.Count != 0)
        {
            IsWaiting = true; // 待機中にする
            // ポップアップウィンドウを作る
          // currentPanel = Instantiate(notificationPanelPrefab.gameObject, canvas.transform).GetComponent<NotificationPanel>();
            //currentPanel.SetText(texts[0]); // テキストを入れる
        }
    }
 
    // アニメーションが終わったら
    public void AnimationEnd()
    {
        // リストから削除
        texts.RemoveAt(0);
        IsWaiting = false; // 待機中でなくする
        StartNext(); // 次のポップアップを表示
    }

public class DialogBox : Notification
{
    public void SetUp(string text, string leftButtonText, string rightButtonText, UnityEngine.Events.UnityAction leftButtonAction, UnityEngine.Events.UnityAction rightButtonAction)
    {
     // メインのテキストにtextを入れる
        transform.GetChild(0).GetComponent<Text>().text = text;
 
        // 左ボタンのテキストにleftButtonTextを入れる
        transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = leftButtonText;
 
        // 右ボタンのテキストにrightButtonTextを入れる
        transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = rightButtonText;
 
        // 左ボタンのOnClickにメソッドを入れる
        transform.GetChild(1).GetChild(0).GetComponent<Button>().onClick.AddListener(leftButtonAction);
 
        // 右ボタンのOnClickにメソッドを入れる
        transform.GetChild(1).GetChild(1).GetComponent<Button>().onClick.AddListener(rightButtonAction);
    }
    [SerializeField] DaiaLog dialogBoxPrefab;

    bool Is IsDisplayingDialog;

    public void ShowDialog(string text, string leftButtonText, string rightButtonText, UnityEngine.Events.UnityAction leftButtonAction, UnityEngine.Events.UnityAction rightButtonAction)
    {
             // ダイアログ表示中でないとき
            if (!IsDisplayingDialog)
            {
                IsDisplayingDialog = true; // 表示中にする
 
                // ダイアログボックスを作成
                GameObject g = Instantiate(dialogBoxPrefab.gameObject, canvas.transform);
 
                // テキストとメソッドを設置絵
                g.GetComponent<DialogBox>().SetUp(text, leftButtonText, rightButtonText, leftButtonAction, rightButtonAction);
 
                DisplayMenuOperation.GetInstance().LockPlayer(); // プレイヤー操作をロック
 
            }
    }
}
}
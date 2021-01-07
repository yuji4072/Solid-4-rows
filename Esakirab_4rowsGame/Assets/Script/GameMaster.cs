using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    TextViewer text = new TextViewer();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //GameOverの設定、シーン遷移を行う
    public void GameOver(int over){
        //Camera.main.targetDisplay = 1;
        text.text(over);
    }
}

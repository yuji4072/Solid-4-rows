using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System;
using System.Threading;

public class SquareCtrl : MonoBehaviour
{   
    //publicにするとインスペクターで参照できる
    public GameObject squareObj; 


    //色関係のあれこれ
    public Color OriginalColor;//初期カラー
    public Color Player1Color;//１Pカラー
    public Color Player2Color;//２Pカラー
    Material Material;


    //ArrayCube.csから(publicにしてはいけない & 初期化しなければならない)
    ArrayCube cube = new ArrayCube(); 
    Judge judge = new Judge();
    //TurnColor turncolor = new TurnColor();
   

    //"count % 2"することでどちらのturn(1p:0 2p:1)か取得できる
    static long count = 0;
    static int turn = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.Material = this.GetComponent<Renderer>().material;
        this.Material.color = OriginalColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickAct(){

        //配列用の座標指定変数
        int x = 0,y =0;

        //16個のマス目のid（0 ~ 15）を抜き出す
        string str = Regex.Replace (squareObj.name, @"[^0-9]", "");
        int id = int.Parse(str);
        
        //色の変更とturnの設定
        if (count % 2 == 0){
            this.Material.color = this.Player1Color;
            turn = 0;
        }else{
            this.Material.color = this.Player2Color;
            turn = 1;
            }

        //３次元配列のxとy座標の取得
        x = cube.DecideArrayX(id);
        y = cube.DecideArrayY(id);

        //指定されたキューへ放り込む
        cube.EnterArray(x, y, turn); 

        // turnをTurnColorへ告げる(注意！　このプログラムを入れるとUnityがクラッシュする！！！！)
        //↑解決、０除算をしていたことが原因だった（嘘です）解決しません
        //turncolor.Turncolor(turn);

        //countを1上げる
        count = count + 1;

        judge.judge();
        
    }
}

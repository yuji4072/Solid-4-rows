using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCube : MonoBehaviour
{

    public static int[][][] cube = new int[4][][];


    void Start()
    {
        this.Arrry();
    }


    public void Arrry(){//三次元配列の定義(2で初期化)

        for (int i = 0; i < 4; i++){
            cube[i] = new int[4][];
        }
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                cube[i][j] = new int[4]{9,9,9,9};
            }
        }  
    }                           

    //キュー（三次元配列）に数値（0 , 1）を格納する
    public void EnterArray(int x, int y,int turn){

        if(cube[x][y][3] == 9){
            cube[x][y][3] = turn;
        }
        else if(cube[x][y][2] == 9){
            cube[x][y][2] = turn;
        }
        else if(cube[x][y][1] == 9){
            cube[x][y][1] = turn;
        }
        else if(cube[x][y][0] == 9){
            cube[x][y][0] = turn;
        }
        else{
            cube[x][y][3] = cube[x][y][2];
            cube[x][y][2] = cube[x][y][1];
            cube[x][y][1] = cube[x][y][0];
            cube[x][y][0] = turn;
        }

        // for(int i = 0; i < 4; i++){
        //     Debug.Log(cube[x][y][i] + "\r\n");
        // }

    }

    //x座標を設定する
    public int DecideArrayX(int id){
        if(id < 4) return 0;
        else if(id < 8) return 1;
        else if(id < 12) return 2;
        else return 3;
    }
    
    //y座標を設定する
    public int DecideArrayY(int id){
        if(id % 4 == 0) return 0;
        else if(id % 4 == 1) return 1;
        else if(id % 4 == 2) return 2;
        else return 3;
    }
    
}

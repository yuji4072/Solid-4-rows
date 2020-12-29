using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    //ArrayCubeからStaticなint cubeを持ってくる
    ArrayCube cube = new ArrayCube();

    //GameMasterを定義する
    GameMaster gamemaster = new GameMaster();

    //縦横斜めそれぞれで判定を行う（もう少し賢く(実行が速く)書ける気もする）
    public void judge(){
        int judge = 0;
        
        //横方向（Xをずらす）判定
        for(int i = 0; i < 4; i++){
            for(int j = 0; j < 4; j++ ){
                judge = 0;
                for (int k = 0; k < 4; k++){
                    if(ArrayCube.cube[k][j][i] == 0) judge = judge + 0;
                    else if(ArrayCube.cube[k][j][i] == 1) judge = judge + 1;
                    else {
                        judge = 9;
                        break;
                    }
                }
                //いずれ揃った列のデータも引数として渡したいので、一回一回関数で判定する。
                toGameMaster(judge);
            }
        }

        //縦方向（ｙをずらす）判定
        for(int i = 0; i < 4; i++){
            for(int j = 0; j < 4; j++ ){
                judge = 0;
                for (int k = 0; k < 4; k++){
                    if(ArrayCube.cube[j][k][i] == 0) judge = judge + 0;
                    else if(ArrayCube.cube[j][k][i] == 1) judge = judge + 1;
                    else {
                        judge = 9;
                        break;
                    }
                }
                //いずれ揃った列のデータも引数として渡したいので、一回一回関数で判定する。
                toGameMaster(judge);
            }
        }

        //奥方向（ｚをずらす）判定
        for(int i = 0; i < 4; i++){
            for(int j = 0; j < 4; j++ ){
                judge = 0;
                for (int k = 0; k < 4; k++){
                    if(ArrayCube.cube[i][j][k] == 0) judge = judge + 0;
                    else if(ArrayCube.cube[i][j][k] == 1) judge = judge + 1;
                    else {
                        judge = 9;
                        break;
                    }
                }
                //いずれ揃った列のデータも引数として渡したいので、一回一回関数で判定する。
                toGameMaster(judge);
            }
        }
        
        //斜め方向を判定する（超非効率な気がする）
        for(int i = 0; i < 4; i++){    
            judge = 0;
            for(int j = 0; j < 4; j++){

                if(ArrayCube.cube[j][j][i] == 0) judge = judge + 0;
                else if(ArrayCube.cube[j][j][i] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
            }
            toGameMaster(judge);
        }
        for(int i = 0; i < 4; i++){    
            judge = 0;
            for(int j = 0; j < 4; j++){

                if(ArrayCube.cube[j][i][j] == 0) judge = judge + 0;
                else if(ArrayCube.cube[j][i][j] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
            }
            toGameMaster(judge);
        }
        for(int i = 0; i < 4; i++){    
            judge = 0;
            for(int j = 0; j < 4; j++){

                if(ArrayCube.cube[i][j][j] == 0) judge = judge + 0;
                else if(ArrayCube.cube[i][j][j] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
            }
            toGameMaster(judge);
        }
        
        
        for(int i = 0; i < 4; i++){
            int k = 3;
            judge = 0;
            for(int j = 0; j < 4; j++){
                if(ArrayCube.cube[k][j][i] == 0) judge = judge + 0;
                else if(ArrayCube.cube[k][j][i] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
                k = k - 1;
            }
            toGameMaster(judge);
        }
        for(int i = 0; i < 4; i++){
            int k = 3;
            judge = 0;
            for(int j = 0; j < 4; j++){
                if(ArrayCube.cube[i][j][k] == 0) judge = judge + 0;
                else if(ArrayCube.cube[i][j][k] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
                k = k - 1;
            }
            toGameMaster(judge);
        }
        for(int i = 0; i < 4; i++){
            int k = 3;
            judge = 0;
            for(int j = 0; j < 4; j++){
                if(ArrayCube.cube[j][i][k] == 0) judge = judge + 0;
                else if(ArrayCube.cube[j][i][k] == 1) judge = judge + 1;
                else {
                    judge = 9;
                    break;
                }
                k = k - 1;
            }
            toGameMaster(judge);
        }

        //以下クロスしている4本を順に見ていく
        judge = 0;    
        for(int i = 0;i < 4; i++){
            if(ArrayCube.cube[i][i][i] == 0) judge = judge + 0;
            else if(ArrayCube.cube[i][i][i] == 1) judge = judge + 1;
            else {
                judge = 9;
                break;
            }
        }
        toGameMaster(judge);

        //頭悪いだけでやってることは一緒
        judge = 0;
        if(ArrayCube.cube[0][0][3] == ArrayCube.cube[1][1][2] &&
           ArrayCube.cube[2][2][1] == ArrayCube.cube[0][0][3] &&
           ArrayCube.cube[3][3][0] == ArrayCube.cube[0][0][3] &&
           ArrayCube.cube[0][0][3] == 0)
           judge = 0;
        else if(ArrayCube.cube[0][0][3] == ArrayCube.cube[1][1][2] &&
           ArrayCube.cube[2][2][1] == ArrayCube.cube[0][0][3] &&
           ArrayCube.cube[3][3][0] == ArrayCube.cube[0][0][3] &&
           ArrayCube.cube[0][0][3] == 0)
           judge = 4;
        else judge = 9;
        toGameMaster(judge);

        judge = 0;
        if(ArrayCube.cube[3][0][0] == ArrayCube.cube[2][1][1] &&
           ArrayCube.cube[3][0][0] == ArrayCube.cube[1][2][2] &&
           ArrayCube.cube[3][0][0] == ArrayCube.cube[0][3][3] &&
           ArrayCube.cube[3][0][0] == 0)
           judge = 0;
        else if(ArrayCube.cube[3][0][0] == ArrayCube.cube[2][1][1] &&
           ArrayCube.cube[3][0][0] == ArrayCube.cube[1][2][2] &&
           ArrayCube.cube[3][0][0] == ArrayCube.cube[0][3][3] &&
           ArrayCube.cube[3][0][0] == 0)
           judge = 4;
        else judge = 9;
        toGameMaster(judge);

        judge = 0;
        if(ArrayCube.cube[3][0][3] == ArrayCube.cube[2][1][2] &&
           ArrayCube.cube[3][0][3] == ArrayCube.cube[1][2][1] &&
           ArrayCube.cube[3][0][3] == ArrayCube.cube[0][3][0] &&
           ArrayCube.cube[3][0][3] == 0)
           judge = 0;
        else if(ArrayCube.cube[3][0][3] == ArrayCube.cube[2][1][2] &&
           ArrayCube.cube[3][0][3] == ArrayCube.cube[1][2][1] &&
           ArrayCube.cube[3][0][3] == ArrayCube.cube[0][3][0] &&
           ArrayCube.cube[3][0][3] == 0)
           judge = 4;
        else judge = 9;
        toGameMaster(judge);

    }


    //勝敗を判定し、勝者が決まった場合数値とともにGameMasterを呼び出す。
    public void toGameMaster(int judge){
        if (judge == 0) gamemaster.GameOver(0);
        else if(judge == 4) gamemaster.GameOver(1);
    }
}

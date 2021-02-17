using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMake : MonoBehaviour
{

    //public GameObject BallsObjprefab;
    //public GameObject BallsObj;
    
    Destroyer destroy = new Destroyer();

    static int number = 0;

    void Start(){
        //Debug.Log(BallsObj.name + BallsObjprefab.name);
        //GameObject s = Instantiate(BallsObjprefab);
    }

    public void makeboll(int x, int y, int turn){
        //GameObject s = Instantiate(BallsObjprefab);
        //, BallsObj.transform
        //s.transform.position = new Vector3((123.17711f + (7f * x)), 30 , (-6.983072f + (7f * y)));

        GameObject obj = (GameObject)Resources.Load("Black_ball");
        GameObject objw = (GameObject)Resources.Load("White_ball");
        if (turn == 0){
            obj.name = "tama" + number;
            GameObject instance = (GameObject)Instantiate(obj,
            new Vector3((124.77711f + (7f * x)), 30 , (-5.382944f + (7f * y))),
            Quaternion.identity);
        }else{
            objw.name = "tama" + number;
            obj.name = "tama" + number;
            GameObject instance = (GameObject)Instantiate(objw,
            new Vector3((124.77711f + (7f * x)), 30 , (-5.382944f + (7f * y))),
            Quaternion.identity);
        }

        destroy.destroy(x, y, obj.name);

        number = number + 1;
    }
}

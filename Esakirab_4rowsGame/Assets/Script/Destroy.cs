using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //static Queue<string> q00,q01,q02,q03,q10,q11,q12,q13,q20,q21,q22,q23,q30,q31,q32,q33;

    
        static List<string> list = new List<string>(new string[]{"0","0","0","0"});
        
        Queue<string> q00 = new Queue<string>(list);
        Queue<string> q01 = new Queue<string>(list);
        Queue<string> q02 = new Queue<string>(list);
        Queue<string> q03 = new Queue<string>(list);
        Queue<string> q10 = new Queue<string>(list);
        Queue<string> q11 = new Queue<string>(list);
        Queue<string> q12 = new Queue<string>(list);
        Queue<string> q13 = new Queue<string>(list);
        Queue<string> q20 = new Queue<string>(list);
        Queue<string> q21 = new Queue<string>(list);
        Queue<string> q22 = new Queue<string>(list);
        Queue<string> q23 = new Queue<string>(list);
        Queue<string> q30 = new Queue<string>(list);
        Queue<string> q31 = new Queue<string>(list);
        Queue<string> q32 = new Queue<string>(list);
        Queue<string> q33 = new Queue<string>(list);
    

    public void destroy(int x,int y, string number){
        //Debug.Log(q00.Peek());
        //Debug.Log(number);
        string tmp;
        if(x == 0 && y == 0){
            q00.Enqueue(number);
            tmp = q00.Dequeue();
            //Debug.Log(tmp);
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 0 && y == 1){
            q01.Enqueue(number);
            tmp = q01.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 0 && y == 2){
            q02.Enqueue(number);
            tmp = q02.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 0 && y == 3){
            q03.Enqueue(number);
            tmp = q03.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 1 && y == 0){
            q10.Enqueue(number);
            tmp = q10.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if (x == 1 && y == 1){
            q10.Enqueue(number);
            tmp = q10.Dequeue();
            if (tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if (x == 1 && y == 2){
            q12.Enqueue(number);
            tmp = q12.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 1 && y == 3){
            q13.Enqueue(number);
            tmp = q13.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 2 && y == 0){
            q20.Enqueue(number);
            tmp = q20.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 2 && y == 1){
            q21.Enqueue(number);
            tmp = q21.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 2 && y == 2){
            q22.Enqueue(number);
            tmp = q22.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 2 && y == 3){
            q23.Enqueue(number);
            tmp = q23.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 3 && y == 0){
            q30.Enqueue(number);
            tmp = q30.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 3 && y == 1){
            q31.Enqueue(number);
            tmp = q31.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 3 && y == 2){
            q32.Enqueue(number);
            tmp = q32.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
            }
        }
        if(x == 3 && y == 3){
            q33.Enqueue(number);
            tmp = q33.Dequeue();
            if(tmp != "0"){
                GameObject obj = GameObject.Find(tmp + "(Clone)");
                Destroy(obj);
             }
        }
    }
    
}

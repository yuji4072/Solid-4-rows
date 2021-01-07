using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextViewer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void text(int over){
        if (over == 2){
            GameObject obj = (GameObject)Resources.Load("1P WIN");
            GameObject instance = (GameObject)Instantiate(obj,
            new Vector3(3.75f, 0 , -2),
            Quaternion.identity);
        }else{
            GameObject obj = (GameObject)Resources.Load("2P WIN");
            GameObject instance = (GameObject)Instantiate(obj,
            new Vector3(3.75f, 0 , -2),
            Quaternion.identity);
        }
        
    }
}

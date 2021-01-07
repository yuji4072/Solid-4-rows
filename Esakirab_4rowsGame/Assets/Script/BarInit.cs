using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarInit : MonoBehaviour
{

    public GameObject BarsObjprefab;
    public GameObject BarsObj;


    void Awake()
    {
        for(int i = 0; i < 4; i++){
            for(int j = 0; j < 4; j++){
                GameObject g = Instantiate(BarsObjprefab, BarsObj.transform);
                g.transform.position = new Vector3((123.17711f + (7f * i)), 18 , (-6.983072f + (7f * j)));
                g.transform.localScale = new Vector3(1, 1.1f, 1);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

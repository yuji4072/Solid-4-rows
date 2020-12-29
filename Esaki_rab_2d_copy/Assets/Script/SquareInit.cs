using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareInit : MonoBehaviour
{

    public GameObject SquaresObjprefab;
    public GameObject SquaresObj;

    int a = 0;

    void Awake()
    {
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                GameObject g = Instantiate(SquaresObjprefab, SquaresObj.transform);
                g.name = "Square" + a;
                a++;
                g.transform.position = new Vector2((-3.375f + (2f * x) + (0.25f * x)),  (3.375f + (-2f * y)+ (-0.25f *y)));
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

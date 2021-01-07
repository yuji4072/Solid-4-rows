using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColor : MonoBehaviour
{

    SquareCtrl ctrl = new SquareCtrl();

    Material Material;
    // Start is called before the first frame update
    void Start()
    {
        this.Material = this.GetComponent<Renderer>().material;
        this.Material.color = ctrl.OriginalColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Turncolor(int turn){
        if (turn == 0){
            this.Material.color = ctrl.Player1Color;
        }else{
            this.Material.color = ctrl.Player2Color;
            }
    }
}

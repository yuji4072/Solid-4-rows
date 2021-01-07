using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = this.GetComponent<Rigidbody>();
        rbody.useGravity = false;
    }

    private void FixedUpdate(){
        SetLocalGravity();
    }

    private void SetLocalGravity(){
        rbody.AddForce(localGravity, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

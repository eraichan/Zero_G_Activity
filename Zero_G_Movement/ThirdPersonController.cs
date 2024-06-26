using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public Transform hedef;
    public Vector3 hedefMesafe;
    [SerializeField]
    private float fareHassasiyeti;
    float fareX, fareY;

    Vector3 objRot;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate(){
        this.transform.position=Vector3.Lerp(this.transform.position,hedef.position+hedefMesafe,Time.deltaTime*10);
        fareX += Input.GetAxis("Mouse X")*fareHassasiyeti;
        fareY += Input.GetAxis("Mouse Y")*fareHassasiyeti;
        if(fareY >= 25){
            fareY = 25;
        }
        if(fareY <= -40){
            fareY = -40;
        }
        this.transform.eulerAngles=new Vector3(fareY,fareX,0);
        hedef.transform.eulerAngles=new Vector3(0,fareX,0);
    }
}

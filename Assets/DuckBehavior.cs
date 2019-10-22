using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckBehavior : MonoBehaviour
{
    int staycount=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Room"){
            staycount=0;
            gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * 100);
            gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 80);
            gameObject.transform.Rotate(new Vector3(0,2,0));
        }
    }

    void OnCollisionStay(Collision col){
        if(col.gameObject.tag == "Room"){
            if(staycount>10){
                gameObject.transform.Rotate(new Vector3(0,2,0));
                gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * 10);
            }
            if(staycount>100){
                gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 1);
            }            
            staycount++;            
        }
    }

}

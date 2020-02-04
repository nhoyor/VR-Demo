using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public Transform cameraPlayer;
    public float angleLim = 30.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = cameraPlayer.rotation.eulerAngles.x;

        if(angle>angleLim && angle<90.0)
        {
            GetComponent<Rigidbody>().velocity = cameraPlayer.forward*speed;
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int moveSpeed = 5;
    public int rotateSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            transform.Rotate(0, -1 * rotateSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);  
            transform.Rotate(0, 1 * rotateSpeed * Time.deltaTime, 0);
        }
    }
}

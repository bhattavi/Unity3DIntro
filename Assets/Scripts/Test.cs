using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1.0f * Time.deltaTime);

        //These are player inputs 
        if (Input.GetKey(KeyCode.A)) transform.Rotate(0, -45 * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.D)) transform.Rotate(0, 45 * Time.deltaTime, 0);

    }
}

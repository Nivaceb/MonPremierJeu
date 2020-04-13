using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machin : MonoBehaviour
{
    public GameObject Roger;
    private Vector3 objectPosition;

    // Start is called before the first frame update
    void Start()
    {
        Roger.transform.position = new Vector3(90, 90, 90);  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("salut");
        objectPosition = Roger.transform.position;
        Debug.Log(objectPosition);
        objectPosition.x += 0.1f;
        Roger.transform.position = objectPosition; 
        
    }
}

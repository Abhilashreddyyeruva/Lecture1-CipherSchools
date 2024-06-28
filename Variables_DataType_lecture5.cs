using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_ : MonoBehaviour
{
   private int myInt = 5;
   
    public string mystring;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The value of x is "+ myInt);

        Debug.Log("my string is" + mystring);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

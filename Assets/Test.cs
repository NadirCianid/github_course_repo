using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] string messageText;
    
    void Start()
    {
       Debug.Log(messageText+" !"); 
    }


    void Update()
    {
        
    }
}

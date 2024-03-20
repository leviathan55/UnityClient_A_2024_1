using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class ExParentClass : MonoBehaviour
{
    protected int protectedValue;
}

public class ExChildClass :ExParentClass
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Protected Value from Child Class : " + protectedValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //This camera follows the object that assigned to "followThis" var. at the inspector. Does not follows z axis.
    //If wanted, change the update method with
    //transform.position = new Vector3(followThis.position.x + offset.x, followThis.position.y + offset.y, offset.z);
    //Offset can be changed at the inspector as well.

    public Transform followThis;
    public Vector3 offset;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(followThis != null)
        {
            transform.position = new Vector3(followThis.position.x + offset.x, followThis.position.y + offset.y, offset.z);
        }
    }
}

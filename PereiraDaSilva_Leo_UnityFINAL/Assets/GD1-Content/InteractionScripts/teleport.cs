using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class teleport : MonoBehaviour
{

    [Header("add this component to your trigger", order = 1)]
    [Header("Drag object to TELEPORT from HIERARCHY", order = 2)]
    public GameObject objectToControl;
    [Header("Choose location to teleport to", order = 3)]
    public Vector3 GetTeleportDestination;
    //[Header("Is this affecting the Player Controller?", order = 4)]
    //public bool isPlayercontroller;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        /*if (isPlayercontroller)
         {
            objectToControl.GetComponent <FirstPersonController> ().enabled = false;
            objectToControl.transform.position = GetTeleportDestination;
            objectToControl.GetComponent <FirstPersonController> ().enabled = true;
            
         }
        else {*/
            objectToControl.transform.position = GetTeleportDestination;
        //}
    }
}

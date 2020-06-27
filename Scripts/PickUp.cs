﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;//destination
    void OnMouseDown(){
      GetComponent<BoxCollider>().enabled=false;
      GetComponent<Rigidbody>().useGravity=false;
      this.transform.position=theDest.position;
      this.transform.parent=GameObject.Find("Destination").transform;
    }
    void OnMouseUp(){
      this.transform.parent=null;
      GetComponent<Rigidbody>().useGravity=true;
      GetComponent<BoxCollider>().enabled=false;
    }
}
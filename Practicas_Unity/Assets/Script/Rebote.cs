using System.Collections;
//using System;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour {

	
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("La pelota colisiono con"+ collision.gameObject.name);
        //Debug.log("La pelota choco con" + collision.gameObject.GetComponent.name);
    }

}

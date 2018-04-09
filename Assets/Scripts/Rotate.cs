using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotSpeed = 1.0f;

    private Transform thisObj;

    void Start()
    {
        // Cachhe the transform link
        thisObj = this.transform;
    }

    void Update()
    {
        thisObj.Rotate(0, Time.deltaTime * rotSpeed, 0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float force;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}

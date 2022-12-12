using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Shooter : MonoBehaviour
{
 [SerializeField] private GameObject boolet;
    private void Start()
    {
        Instantiate(boolet, transform.position, Quaternion.identity);
    }

   
}

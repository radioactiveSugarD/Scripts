using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
      Debug.Log("Entered");
      if(c.tag == "CanBeDestroyed")
      {
        Debug.Log("Killing");
        c.GetComponent<Destroyed>().Die();
      }
    }
}

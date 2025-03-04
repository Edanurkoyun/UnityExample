using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ornek2 : MonoBehaviour
{
    // Start is called before the first frame update
   public Vector3 newposition;
    public GameObject mevcutobje;
    void Start()
    {
      newposition= new Vector3(15f,15f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(newposition);
    }
}

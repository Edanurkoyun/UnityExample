using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornek2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Vertical");  // Ýleri-geri hareket
        float moveX = Input.GetAxis("Horizontal"); // Sað-sol hareket

        // Hareketi uygula
        transform.position = transform.position + new Vector3(moveX * speed * Time.deltaTime, 0, moveZ * speed * Time.deltaTime);
    }
}

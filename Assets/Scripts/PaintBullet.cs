using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class PaintBullet : MonoBehaviour
{   

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material.color = this.gameObject.GetComponent<MeshRenderer>().material.color;
    }
}

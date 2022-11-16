using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienGun : Gun
{
    // Start is called before the first frame update
    public override void Shoot()
    {
        base.Shoot();
        tempBullet.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}

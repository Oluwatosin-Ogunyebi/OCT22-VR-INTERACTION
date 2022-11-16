using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public float shootSpeed;

    public GameObject tempBullet;
    // Start is called before the first frame update
    public virtual void Shoot()
    {
        tempBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        tempBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootSpeed);
        Destroy(tempBullet, 5f);
    }


}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using easyInputs;

public class GunManager : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletSpawn;
    public AudioSource shotSound;

    public bool trigger = false;

    public float speed = 10f;
    private float counter = 10f;

    private void Update()
    {
        if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) || trigger)
        {
            if (counter == 0)
            {
                counter = 5;
                GameObject newBullet = Instantiate(Bullet);
                newBullet.transform.position = BulletSpawn.position;
                newBullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * speed;
                shotSound.Play();
                Destroy(newBullet, 3);
            }

            else if (counter > 0)
            {
                counter -= 1;
            }
        }
    }
            
        }
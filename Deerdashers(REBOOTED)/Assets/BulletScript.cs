using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
//public float speed = 0.1f;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
   
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
   //     transform.localPosition += direction;
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
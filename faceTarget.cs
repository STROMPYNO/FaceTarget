using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceTarget : MonoBehaviour
{
    public float speed;
    public GameObject target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FaceTarget();
    }

    void FaceTarget()
    {

        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 3f);

    }
}

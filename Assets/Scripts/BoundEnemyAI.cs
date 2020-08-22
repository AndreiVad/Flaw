using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoundEnemyAI : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;

    void Update()
    {
         
        transform.LookAt(target);
    }
}
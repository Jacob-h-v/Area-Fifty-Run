using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(20, 35, 45) * Time.deltaTime ,Space.World);
    }
}

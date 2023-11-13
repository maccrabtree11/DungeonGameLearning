using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpin : MonoBehaviour
{
    public GameObject[] propellors;
    public GameObject noseCone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject propellor in propellors) {
            propellor.transform.RotateAround(noseCone.transform.position, Vector3.forward, 600 * Time.deltaTime);
        }
    }
}

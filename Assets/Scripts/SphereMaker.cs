using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    public GameObject sphere;
    public int numberOfSpheres = 16;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < numberOfSpheres; i++)
        {
            var duplicateSphere = GameObject.Instantiate(sphere);
            duplicateSphere.transform.position = new Vector3(i, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

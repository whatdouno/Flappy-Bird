using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{

    public GameObject[] grounds;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(grounds[0].transform.localPosition.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) // If it collides
        {
            return;
        }
        gameObject.transform.localPosition += new Vector3(-0.05f, 0, 0);

        if (gameObject.transform.localPosition.x < -39.5f)
        {
            gameObject.transform.localPosition = new Vector3(-12.1f, -5.83f, 0); 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupidBirdControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1600, 800, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(0, 300, 0);
        }

        if (Input.GetKeyDown("r")) {
            Time.timeScale = 1;
            Debug.Log("Restart Pressed.");
        }
    }
    //절대 함수 이름 바꾸지 말 것! (충돌 시 작동하는 override 함수.)
    void OnCollisionEnter (Collision collision){ 
        Debug.Log("GameOver");
        Time.timeScale = 0; // 모든 것이 정지한 상태를 구현할 때 쓰임.
    }
}

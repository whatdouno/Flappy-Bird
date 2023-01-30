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
    //���� �Լ� �̸� �ٲ��� �� ��! (�浹 �� �۵��ϴ� override �Լ�.)
    void OnCollisionEnter (Collision collision){ 
        Debug.Log("GameOver");
        Time.timeScale = 0; // ��� ���� ������ ���¸� ������ �� ����.
    }
}

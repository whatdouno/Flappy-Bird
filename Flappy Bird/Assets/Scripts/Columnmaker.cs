using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnmaker : MonoBehaviour
{
    public GameObject Column;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            GameObject temp = Instantiate(Column);
            Transform parent = temp.transform.parent;
            temp.transform.parent = null;
                


            temp.transform.localPosition = new Vector3(16.6f, -1.3f, 0);
            temp.transform.localScale = new Vector3(1, 1, 1);

            temp.transform.parent = parent;
           
            /*Destroy(temp, 시간) 쓰면 Instantiate 기준으로 '시간' 뒤에 사라짐.*/
            Destroy(temp, 16f);

            /*timer 0으로 조정해야함. -  timer > 2f 작동 조건이 애초에 정수일때 딱 떨어지지 않음.*/
            
            timer = 0;
        }
        
    }
}

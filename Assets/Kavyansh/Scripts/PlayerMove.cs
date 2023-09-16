using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] string _code = "Kavyansh";
    [SerializeField] string _InputCode;
    [SerializeField] bool _Iscode;
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float Xinput = Input.GetAxisRaw("Horizontal");
        float Yinput = Input.GetAxisRaw("Vertical");
        if (Xinput > 0)
        {
            transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
        }
        else if (Xinput < 0)
        {
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

        if (Yinput > 0)
        {
            transform.Translate(new Vector3(0, _speed * Time.deltaTime, 0));
        }
        else if (Yinput < 0)
        {
            transform.Translate(new Vector3(0, -_speed * Time.deltaTime, 0));
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paletas : MonoBehaviour
{
    public bool isPaddle1;
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        if (isPaddle1)
        {
            transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime,0f, 0f);
            Vector3 pos = transform.position;

            pos.z = Mathf.Clamp(pos.z, -2.857f, -2.857f);
            pos.x = Mathf.Clamp(pos.x, 0.084f, 1.238f);

            transform.position = pos;
        } else
        {
            transform.Translate(Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f, 0f);
            Vector3 pos2 = transform.position;

            pos2.z = Mathf.Clamp(pos2.z, 1.911f, 1.911f);
            pos2.x = Mathf.Clamp(pos2.x, -0.048f, 1.09f);

            transform.position = pos2;
        }
    }
}

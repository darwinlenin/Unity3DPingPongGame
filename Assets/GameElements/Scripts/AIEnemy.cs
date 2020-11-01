using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public GameObject Esfera;
    public GameObject AI;
    public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        Esfera = GameObject.FindWithTag("Esfera");
        AI = GameObject.FindWithTag("AI");

        if (Esfera.transform.position.y > 0)
        {
            AI.transform.position = Vector3.MoveTowards(transform.position, Esfera.transform.position, Time.deltaTime * speed);
        } else if (Esfera.transform.position.y < 0)
        {
            AI.transform.position = Vector3.MoveTowards(transform.position, Esfera.transform.position, Time.deltaTime * speed);
        }
    }
}

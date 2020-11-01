using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTraversal : MonoBehaviour
{
    public ePlayer player;

    public float speed = 4f;

    private void OnCollisionEnter(Collision collision)
    {
        Esfera esfera = collision.gameObject.GetComponent<Esfera>();

        float xy = Random.Range(0, 2) == 0 ? 1 : -1;
        float yx = Random.Range(0, 2) == 0 ? -2 : 2;

        if(esfera != null)
        {
            if(player == ePlayer.Right)
            {
                esfera.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * xy, 0f, speed * yx), ForceMode.Force);
            } else if(player == ePlayer.Left)
            {
                esfera.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * xy, 0f, speed * yx), ForceMode.Force);
            }
        }

    }

}

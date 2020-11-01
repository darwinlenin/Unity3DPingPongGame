using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{
    public ePlayer player;

    public float speed = 4f;
    public ScoreUI score;
    public AudioSource audioSource;
    //public AudioClip clip;
    public float volume = 0.5f;

    private void OnCollisionEnter(Collision collision)
    {
        Esfera esfera = collision.gameObject.GetComponent<Esfera>();

        float xy = Random.Range(0, 2) == 0 ? 2 : -2;
        float yx = Random.Range(0, 2) == 0 ? -1 : 1;

        Light myLight = GetComponent<Light>();

        if (esfera != null)
        {
            if (player == ePlayer.Right)
            {
                score.scorePlayerRight++;
                esfera.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * xy, speed * yx, 0f), ForceMode.Force);
                myLight.intensity = Mathf.PingPong(Time.time , 8);
                audioSource.Play();
            }
            else if (player == ePlayer.Left)
            {
                score.scorePlayerLeft++;
                esfera.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * xy, speed * yx, 0f), ForceMode.Force);
                myLight.intensity = Mathf.PingPong(Time.time, 8);
                audioSource.Play();
            }
        }

    }
}

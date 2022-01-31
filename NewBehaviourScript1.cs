using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    public string ррр;
    public AudioSource AppearSFX;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            SceneManager.LoadScene(ррр);
            AppearSFX.Play();
        }

    }
}

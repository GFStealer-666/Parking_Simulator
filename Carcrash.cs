using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carcrash : MonoBehaviour
{
    public GameObject Gameoverscreen;

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Main_Body")
        {
            yield return new WaitForSeconds(1);

            Gameoverscreen.SetActive(true);

            yield return new WaitForSeconds(5);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}

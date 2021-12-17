using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public GameObject Victoryscreen;

    public bool LFwheel = false, RFwheel = false, LBwheel = false, RBwheel = false;

    private IEnumerator OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Front_Left_Wheel")
        {
            LFwheel = true;
        }
        if (other.gameObject.name == "Front_Right_Wheel")
        {
            RFwheel = true;
        }
        if (other.gameObject.name == "Rear_Left_Wheel")
        {
            LBwheel = true;
        }
        if (other.gameObject.name == "Rear_Right_Wheel")
        {
            RBwheel = true;
        }
        if (LFwheel == true && RFwheel == true && LBwheel == true && RBwheel == true)
        {
            yield return new WaitForSeconds(1);

            Victoryscreen.SetActive(true);
            
            yield return new WaitForSeconds(5);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Front_Left_Wheel")
        {
            LFwheel = false;
        }
        if (other.gameObject.name == "Front_Right_Wheel")
        {
            RFwheel = false;
        }
        if (other.gameObject.name == "Rear_Left_Wheel")
        {
            LBwheel = false;
        }
        if (other.gameObject.name == "Rear_Right_Wheel")
        {
            RBwheel = false;
        }
    }

    private void Update()
    {
        /*if (GameObject.FindGameObjectWithTag("Wheel1"))
        {
            Debug.Log("GG");
        } */
    }
}
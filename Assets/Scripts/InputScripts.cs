using UnityEngine;

public class InputScripts : MonoBehaviour
{
     public AudioSource spacebarSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed!");
            // Perform jump action
            spacebarSound.Play();
        }

    }
}

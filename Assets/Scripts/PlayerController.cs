using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public AudioSource ExplosionAudio;

    //audio FX 
    public AudioSource obstacleAudio;

    //particle fx
    public GameObject ExplosionPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
void OnTriggerEnter (Collider other)
{
  if (other.gameObject.CompareTag("Barrels"))
  {
    Instantiate(ExplosionPrefab, other.transform.position, other.transform.rotation);
    other.gameObject.SetActive(false);
    ExplosionAudio.Play();
  }

   if (other.gameObject.CompareTag("Obstacle"))
  {
    other.gameObject.SetActive(false);
    obstacleAudio.Play();
  }
}





/*
void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Barrels"))

    {

        // Get the AudioSource component from the obstacle we hit.
        AudioSource objectAudio = collision.gameObject.GetComponent<AudioSource>();

        // If the obstacle has an AudioSource, play its sound.
        if (objectAudio != null)
        {
            objectAudio.Play();
        }
    }

    }
    */



    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

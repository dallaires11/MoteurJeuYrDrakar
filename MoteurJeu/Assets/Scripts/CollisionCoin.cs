using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCoin : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    public ScoreTracker scoreTracker;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            audioSource.Play();
            StartCoroutine("Test");

        }
    }
    IEnumerator Test()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        //yield return StartCoroutine("WaitAndPrint");
        scoreTracker.score += 1;
        yield return new WaitForSeconds(0.6f);

        Destroy(gameObject);
        print("Done " + Time.time);
    }
}

using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);
    }
}

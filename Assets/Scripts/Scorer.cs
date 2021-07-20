using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    [SerializeField] Text textio;
    
    void OnCollisionEnter(Collision other)
    {
        hits++;
    }

    void Update()
    {
        textio.text = ("Bumps: " + hits.ToString());
    }
}

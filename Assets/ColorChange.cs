using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public float duration;
    public GameObject tile;
    public float initial;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float theta = (initial+Time.time)/duration*10;
        float amp = (Mathf.Cos(theta)+1.0f)/2;
        tile.GetComponent<Renderer>().material.color = Color.HSVToRGB(amp, 1, 1);
    }
}

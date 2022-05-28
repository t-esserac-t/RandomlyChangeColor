using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayOutTiles : MonoBehaviour
{
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        float count = 0;

        for (int i=0;i<=30;i++)
        {
            GameObject obj = Instantiate(tile, new Vector3(0f, 0f, -1f*i), Quaternion.identity);
            obj.GetComponent<ColorChange>().initial = count;
            count += 0.1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

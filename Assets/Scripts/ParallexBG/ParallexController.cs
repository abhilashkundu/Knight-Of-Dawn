using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallexController : MonoBehaviour
{
    private float startPos, length;
    [SerializeField] private float parallexeffect;
    public GameObject mainCam;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (mainCam.transform.position.x * (1 - parallexeffect));
        float dis = (mainCam.transform.position.x * parallexeffect);

       transform.position = new Vector3(startPos + dis, transform.position.y, transform.position.z);

        if (temp > (startPos + length)) startPos += length;
        else if (temp < (startPos - length)) startPos -= length;
    }
}

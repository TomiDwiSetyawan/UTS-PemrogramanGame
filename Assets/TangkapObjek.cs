using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TangkapObjek : MonoBehaviour
{
    public Text namaText;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;
    // Start is called before the first frame update
    public GameObject bola;
    public GameObject tangan;
    public GameObject cube;

    bool tertangkap = false;
    Vector3 posisiBola;
    void Start()
    {
        posisiBola = bola.transform.position;
        cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            namaText.gameObject.SetActive(false);
            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(5.88f, 2.95f, 0f);
                cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
                bola.GetComponent<Renderer>().material.color = Color.blue;
                tertangkap = true;
                namaText.text = "bola ditangkap";
                namaText.gameObject.SetActive(true);

            } else if (tertangkap)
            {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
                bola.GetComponent<Renderer>().material.color = Color.red;
                tertangkap = false;
                namaText.text = "bola dilepas";
                namaText.gameObject.SetActive(true);
            }
            
        }
    }
}

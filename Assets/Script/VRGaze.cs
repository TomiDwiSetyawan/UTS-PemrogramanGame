using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imgGaze;
    public Text namaText;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;

            if (imgGaze.fillAmount == 1)
            {
                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                namaText.gameObject.SetActive(false);

                if (Physics.Raycast(ray, out _hit, distanceOfRay))
                {
                    if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Hitam"))
                    {
                        gvrStatus = false;
                        gvrTimer = 0;
                        imgGaze.fillAmount = 0;
                        namaText.text = "ini kubu hitam";
                        namaText.gameObject.SetActive(true);
                    }else if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Merah"))
                    {
                        gvrStatus = false;
                        gvrTimer = 0;
                        imgGaze.fillAmount = 0;
                        namaText.text = "ini kubu merah";
                        namaText.gameObject.SetActive(true);
                    }

                   
                }

            }

        }
    }

    public void GVRon()
    {
        gvrStatus = true;
    }

    public void GVRoff()
    {
        gvrStatus = false;
        namaText.gameObject.SetActive(false);
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}

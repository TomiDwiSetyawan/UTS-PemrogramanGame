using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PindahMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void HalamanUtama(string halaman)
   {
        SceneManager.LoadScene(halaman);
   }

    public void KeluarAplikasi()
    {
        Application.Quit();
    }
}

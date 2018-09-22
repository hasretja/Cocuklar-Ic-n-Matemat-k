using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kesirorta : MonoBehaviour {
    public GameObject[] dogrruu1;
    public GameObject[] yanlliss1;
    public GameObject[] dogrruu2;
    public GameObject[] yanlliss2;
    public GameObject[] dogrruu3;
    public GameObject[] yanlliss3;
    public GameObject[] dogrruu4;
    public GameObject[] yanlliss4;
    public GameObject[] dogrruu5;
    public GameObject[] yanlliss5;
    public GameObject[] dogrruu6;
    public GameObject[] yanlliss6;
    public GameObject[] dogrruu7;
    public GameObject[] yanlliss7;
    public GameObject[] paneelll;
    public Text puuann;
    public Text dogrrularr;
    public Text yanllislarr;
    public Text rekkorr;
    public float puannıı;
    public float dogrrusuu;
    public float yannlisii;
    void Start () {
        dogrruu1[0].SetActive(false);
        dogrruu1[1].SetActive(false);
        dogrruu1[2].SetActive(false);
        dogrruu1[3].SetActive(false);
        dogrruu1[4].SetActive(false);
        dogrruu1[5].SetActive(false);
        dogrruu1[6].SetActive(false);

        yanlliss1[0].SetActive(false);
        yanlliss1[1].SetActive(false);
        yanlliss1[2].SetActive(false);
        yanlliss1[3].SetActive(false);
        yanlliss1[4].SetActive(false);
        yanlliss1[5].SetActive(false);
        yanlliss1[6].SetActive(false);

        dogrruu2[0].SetActive(false);
        dogrruu2[1].SetActive(false);
        dogrruu2[2].SetActive(false);
        dogrruu2[3].SetActive(false);
        dogrruu2[4].SetActive(false);
        dogrruu2[5].SetActive(false);



        yanlliss2[0].SetActive(false);
        yanlliss2[1].SetActive(false);
        yanlliss2[2].SetActive(false);
        yanlliss2[3].SetActive(false);
        yanlliss2[4].SetActive(false);
        yanlliss2[5].SetActive(false);


        dogrruu3[0].SetActive(false);
        dogrruu3[1].SetActive(false);
        dogrruu3[2].SetActive(false);
        dogrruu3[3].SetActive(false);
        dogrruu3[4].SetActive(false);


        yanlliss3[0].SetActive(false);
        yanlliss3[1].SetActive(false);
        yanlliss3[2].SetActive(false);
        yanlliss3[3].SetActive(false);
        yanlliss3[4].SetActive(false);

        dogrruu4[0].SetActive(false);
        dogrruu4[1].SetActive(false);
        dogrruu4[2].SetActive(false);
        dogrruu4[3].SetActive(false);


        yanlliss4[0].SetActive(false);
        yanlliss4[1].SetActive(false);
        yanlliss4[2].SetActive(false);
        yanlliss4[3].SetActive(false);


        dogrruu5[0].SetActive(false);
        dogrruu5[1].SetActive(false);
        dogrruu5[2].SetActive(false);


        yanlliss5[0].SetActive(false);
        yanlliss5[1].SetActive(false);
        yanlliss5[2].SetActive(false);


        dogrruu6[0].SetActive(false);
        dogrruu6[1].SetActive(false);

        yanlliss6[0].SetActive(false);
        yanlliss6[1].SetActive(false);

        dogrruu7[0].SetActive(false);

        yanlliss7[0].SetActive(false);
    }
    public void dou1()
    {
        dogrruu1[0].SetActive(true);
        dogrruu1[1].SetActive(true);
        dogrruu1[2].SetActive(true);
        dogrruu1[3].SetActive(true);
        dogrruu1[4].SetActive(true);
        dogrruu1[5].SetActive(true);
        dogrruu1[6].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(true);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou2()
    {
        dogrruu2[0].SetActive(true);
        dogrruu2[1].SetActive(true);
        dogrruu2[2].SetActive(true);
        dogrruu2[3].SetActive(true);
        dogrruu2[4].SetActive(true);
        dogrruu2[5].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(true);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou3()
    {
        dogrruu3[0].SetActive(true);
        dogrruu3[1].SetActive(true);
        dogrruu3[2].SetActive(true);
        dogrruu3[3].SetActive(true);
        dogrruu3[4].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(true);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou4()
    {
        dogrruu4[0].SetActive(true);
        dogrruu4[1].SetActive(true);
        dogrruu4[2].SetActive(true);
        dogrruu4[3].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(true);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou5()
    {
        dogrruu5[0].SetActive(true);
        dogrruu5[1].SetActive(true);
        dogrruu5[2].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(true);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou6()
    {
        dogrruu6[0].SetActive(true);
        dogrruu6[1].SetActive(true);


        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(true);
        paneelll[7].SetActive(false);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void dou7()
    {
        dogrruu7[0].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(true);
        puannıı = puannıı + 10;
        dogrrusuu = dogrrusuu + 1;
    }
    public void yais1()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);
        yanlliss1[2].SetActive(true);
        yanlliss1[3].SetActive(true);
        yanlliss1[4].SetActive(true);
        yanlliss1[5].SetActive(true);
        yanlliss1[6].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(true);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais2()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);
        yanlliss1[2].SetActive(true);
        yanlliss1[3].SetActive(true);
        yanlliss1[4].SetActive(true);
        yanlliss1[5].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(true);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais3()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);
        yanlliss1[2].SetActive(true);
        yanlliss1[3].SetActive(true);
        yanlliss1[4].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(true);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais4()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);
        yanlliss1[2].SetActive(true);
        yanlliss1[3].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(true);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais5()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);
        yanlliss1[2].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(true);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais6()
    {
        yanlliss1[0].SetActive(true);
        yanlliss1[1].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(true);
        paneelll[7].SetActive(false);

        yannlisii = yannlisii + 1;
    }
    public void yais7()
    {
        yanlliss1[0].SetActive(true);

        paneelll[0].SetActive(false);
        paneelll[1].SetActive(false);
        paneelll[2].SetActive(false);
        paneelll[3].SetActive(false);
        paneelll[4].SetActive(false);
        paneelll[5].SetActive(false);
        paneelll[6].SetActive(false);
        paneelll[7].SetActive(true);

        yannlisii = yannlisii + 1;
    }
    void Update () {
        if (puannıı > PlayerPrefs.GetFloat("Re7"))
        {

            PlayerPrefs.SetFloat("Re7", puannıı);

        }
        rekkorr.text = PlayerPrefs.GetFloat("Re7").ToString();
        dogrrularr.text = dogrrusuu.ToString();
        puuann.text = puannıı.ToString();
        yanllislarr.text = yannlisii.ToString();
    }
}

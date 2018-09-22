using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zamanorta : MonoBehaviour {
    public GameObject[] ogrruu1;
    public GameObject[] anlliss1;
    public GameObject[] ogrruu2;
    public GameObject[] anlliss2;
    public GameObject[] ogrruu3;
    public GameObject[] anlliss3;
    public GameObject[] ogrruu4;
    public GameObject[] anlliss4;
    public GameObject[] ogrruu5;
    public GameObject[] anlliss5;
    public GameObject[] ogrruu6;
    public GameObject[] anlliss6;
    public GameObject[] ogrruu7;
    public GameObject[] anlliss7;
    public GameObject[] aneelll;
    public Text uuann;
    public Text ogrrularr;
    public Text anllislarr;
    public Text ekkorr;
    public float uannıı;
    public float ogrrusuu;
    public float annlisii;
    void Start () {
        ogrruu1[0].SetActive(false);
        ogrruu1[1].SetActive(false);
        ogrruu1[2].SetActive(false);
        ogrruu1[3].SetActive(false);
        ogrruu1[4].SetActive(false);
        ogrruu1[5].SetActive(false);
        ogrruu1[6].SetActive(false);

        anlliss1[0].SetActive(false);
        anlliss1[1].SetActive(false);
        anlliss1[2].SetActive(false);
        anlliss1[3].SetActive(false);
        anlliss1[4].SetActive(false);
        anlliss1[5].SetActive(false);
        anlliss1[6].SetActive(false);

        ogrruu2[0].SetActive(false);
        ogrruu2[1].SetActive(false);
        ogrruu2[2].SetActive(false);
        ogrruu2[3].SetActive(false);
        ogrruu2[4].SetActive(false);
        ogrruu2[5].SetActive(false);



        anlliss2[0].SetActive(false);
        anlliss2[1].SetActive(false);
        anlliss2[2].SetActive(false);
        anlliss2[3].SetActive(false);
        anlliss2[4].SetActive(false);
        anlliss2[5].SetActive(false);


        ogrruu3[0].SetActive(false);
        ogrruu3[1].SetActive(false);
        ogrruu3[2].SetActive(false);
        ogrruu3[3].SetActive(false);
        ogrruu3[4].SetActive(false);


        anlliss3[0].SetActive(false);
        anlliss3[1].SetActive(false);
        anlliss3[2].SetActive(false);
        anlliss3[3].SetActive(false);
        anlliss3[4].SetActive(false);

        ogrruu4[0].SetActive(false);
        ogrruu4[1].SetActive(false);
        ogrruu4[2].SetActive(false);
        ogrruu4[3].SetActive(false);


        anlliss4[0].SetActive(false);
        anlliss4[1].SetActive(false);
        anlliss4[2].SetActive(false);
        anlliss4[3].SetActive(false);


        ogrruu5[0].SetActive(false);
        ogrruu5[1].SetActive(false);
        ogrruu5[2].SetActive(false);


        anlliss5[0].SetActive(false);
        anlliss5[1].SetActive(false);
        anlliss5[2].SetActive(false);


        ogrruu6[0].SetActive(false);
        ogrruu6[1].SetActive(false);

        anlliss6[0].SetActive(false);
        anlliss6[1].SetActive(false);

        ogrruu7[0].SetActive(false);

        anlliss7[0].SetActive(false);
    }
    public void dour1()
    {
        ogrruu1[0].SetActive(true);
        ogrruu1[1].SetActive(true);
        ogrruu1[2].SetActive(true);
        ogrruu1[3].SetActive(true);
        ogrruu1[4].SetActive(true);
        ogrruu1[5].SetActive(true);
        ogrruu1[6].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(true);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour2()
    {
        ogrruu2[0].SetActive(true);
        ogrruu2[1].SetActive(true);
        ogrruu2[2].SetActive(true);
        ogrruu2[3].SetActive(true);
        ogrruu2[4].SetActive(true);
        ogrruu2[5].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(true);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour3()
    {
        ogrruu3[0].SetActive(true);
        ogrruu3[1].SetActive(true);
        ogrruu3[2].SetActive(true);
        ogrruu3[3].SetActive(true);
        ogrruu3[4].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(true);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour4()
    {
        ogrruu4[0].SetActive(true);
        ogrruu4[1].SetActive(true);
        ogrruu4[2].SetActive(true);
        ogrruu4[3].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(true);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour5()
    {
        ogrruu5[0].SetActive(true);
        ogrruu5[1].SetActive(true);
        ogrruu5[2].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(true);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour6()
    {
        ogrruu6[0].SetActive(true);
        ogrruu6[1].SetActive(true);


        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(true);
        aneelll[7].SetActive(false);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void dour7()
    {
        ogrruu7[0].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(true);
        uannıı = uannıı + 10;
        ogrrusuu = ogrrusuu + 1;
    }
    public void yails1()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);
        anlliss1[2].SetActive(true);
        anlliss1[3].SetActive(true);
        anlliss1[4].SetActive(true);
        anlliss1[5].SetActive(true);
        anlliss1[6].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(true);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails2()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);
        anlliss1[2].SetActive(true);
        anlliss1[3].SetActive(true);
        anlliss1[4].SetActive(true);
        anlliss1[5].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(true);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails3()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);
        anlliss1[2].SetActive(true);
        anlliss1[3].SetActive(true);
        anlliss1[4].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(true);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails4()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);
        anlliss1[2].SetActive(true);
        anlliss1[3].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(true);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails5()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);
        anlliss1[2].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(true);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails6()
    {
        anlliss1[0].SetActive(true);
        anlliss1[1].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(true);
        aneelll[7].SetActive(false);

        annlisii = annlisii + 1;
    }
    public void yails7()
    {
        anlliss1[0].SetActive(true);

        aneelll[0].SetActive(false);
        aneelll[1].SetActive(false);
        aneelll[2].SetActive(false);
        aneelll[3].SetActive(false);
        aneelll[4].SetActive(false);
        aneelll[5].SetActive(false);
        aneelll[6].SetActive(false);
        aneelll[7].SetActive(true);

        annlisii = annlisii + 1;
    }
    void Update () {
        if (uannıı > PlayerPrefs.GetFloat("RekSAİ"))
        {

            PlayerPrefs.SetFloat("RekSAİ", uannıı);

        }
        ekkorr.text = PlayerPrefs.GetFloat("RekSAİ").ToString();
        ogrrularr.text = ogrrusuu.ToString();
        uuann.text = uannıı.ToString();
        anllislarr.text = annlisii.ToString();
    }
}
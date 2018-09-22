using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sayilarorta : MonoBehaviour {
    public GameObject[] sayilarortadogrruu1;
    public GameObject[] sayilarortayanlliss1;
    public GameObject[] sayilarortadogrruu2;
    public GameObject[] sayilarortayanlliss2;
    public GameObject[] sayilarortadogrruu3;
    public GameObject[] sayilarortayanlliss3;
    public GameObject[] sayilarortadogrruu4;
    public GameObject[] sayilarortayanlliss4;
    public GameObject[] sayilarortadogrruu5;
    public GameObject[] sayilarortayanlliss5;
    public GameObject[] sayilarortadogrruu6;
    public GameObject[] sayilarortayanlliss6;
    public GameObject[] sayilarortadogrruu7;
    public GameObject[] sayilarortayanlliss7;
    public GameObject[] sayilarortapaneelll;
    public Text sayilarortapuuann;
    public Text sayilarortadogrrularr;
    public Text sayilarortayanllislarr;
    public Text sayilarortarekkorr;
    public float sayilarortapuannıı;
    public float sayilarortadogrrusuu;
    public float sayilarortayannlisii;
    void Start () {
        sayilarortadogrruu1[0].SetActive(false);
        sayilarortadogrruu1[1].SetActive(false);
        sayilarortadogrruu1[2].SetActive(false);
        sayilarortadogrruu1[3].SetActive(false);
        sayilarortadogrruu1[4].SetActive(false);
        sayilarortadogrruu1[5].SetActive(false);
        sayilarortadogrruu1[6].SetActive(false);

        sayilarortayanlliss1[0].SetActive(false);
        sayilarortayanlliss1[1].SetActive(false);
        sayilarortayanlliss1[2].SetActive(false);
        sayilarortayanlliss1[3].SetActive(false);
        sayilarortayanlliss1[4].SetActive(false);
        sayilarortayanlliss1[5].SetActive(false);
        sayilarortayanlliss1[6].SetActive(false);

        sayilarortadogrruu2[0].SetActive(false);
        sayilarortadogrruu2[1].SetActive(false);
        sayilarortadogrruu2[2].SetActive(false);
        sayilarortadogrruu2[3].SetActive(false);
        sayilarortadogrruu2[4].SetActive(false);
        sayilarortadogrruu2[5].SetActive(false);



        sayilarortayanlliss2[0].SetActive(false);
        sayilarortayanlliss2[1].SetActive(false);
        sayilarortayanlliss2[2].SetActive(false);
        sayilarortayanlliss2[3].SetActive(false);
        sayilarortayanlliss2[4].SetActive(false);
        sayilarortayanlliss2[5].SetActive(false);


        sayilarortadogrruu3[0].SetActive(false);
        sayilarortadogrruu3[1].SetActive(false);
        sayilarortadogrruu3[2].SetActive(false);
        sayilarortadogrruu3[3].SetActive(false);
        sayilarortadogrruu3[4].SetActive(false);


        sayilarortayanlliss3[0].SetActive(false);
        sayilarortayanlliss3[1].SetActive(false);
        sayilarortayanlliss3[2].SetActive(false);
        sayilarortayanlliss3[3].SetActive(false);
        sayilarortayanlliss3[4].SetActive(false);

        sayilarortadogrruu4[0].SetActive(false);
        sayilarortadogrruu4[1].SetActive(false);
        sayilarortadogrruu4[2].SetActive(false);
        sayilarortadogrruu4[3].SetActive(false);


        sayilarortayanlliss4[0].SetActive(false);
        sayilarortayanlliss4[1].SetActive(false);
        sayilarortayanlliss4[2].SetActive(false);
        sayilarortayanlliss4[3].SetActive(false);


        sayilarortadogrruu5[0].SetActive(false);
        sayilarortadogrruu5[1].SetActive(false);
        sayilarortadogrruu5[2].SetActive(false);


        sayilarortayanlliss5[0].SetActive(false);
        sayilarortayanlliss5[1].SetActive(false);
        sayilarortayanlliss5[2].SetActive(false);


        sayilarortadogrruu6[0].SetActive(false);
        sayilarortadogrruu6[1].SetActive(false);

        sayilarortayanlliss6[0].SetActive(false);
        sayilarortayanlliss6[1].SetActive(false);

        sayilarortadogrruu7[0].SetActive(false);

        sayilarortayanlliss7[0].SetActive(false);
    }
    public void sayilarortadou1()
    {
        sayilarortadogrruu1[0].SetActive(true);
        sayilarortadogrruu1[1].SetActive(true);
        sayilarortadogrruu1[2].SetActive(true);
        sayilarortadogrruu1[3].SetActive(true);
        sayilarortadogrruu1[4].SetActive(true);
        sayilarortadogrruu1[5].SetActive(true);
        sayilarortadogrruu1[6].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(true);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou2()
    {
        sayilarortadogrruu2[0].SetActive(true);
        sayilarortadogrruu2[1].SetActive(true);
        sayilarortadogrruu2[2].SetActive(true);
        sayilarortadogrruu2[3].SetActive(true);
        sayilarortadogrruu2[4].SetActive(true);
        sayilarortadogrruu2[5].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(true);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou3()
    {
        sayilarortadogrruu3[0].SetActive(true);
        sayilarortadogrruu3[1].SetActive(true);
        sayilarortadogrruu3[2].SetActive(true);
        sayilarortadogrruu3[3].SetActive(true);
        sayilarortadogrruu3[4].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(true);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou4()
    {
        sayilarortadogrruu4[0].SetActive(true);
        sayilarortadogrruu4[1].SetActive(true);
        sayilarortadogrruu4[2].SetActive(true);
        sayilarortadogrruu4[3].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(true);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou5()
    {
        sayilarortadogrruu5[0].SetActive(true);
        sayilarortadogrruu5[1].SetActive(true);
        sayilarortadogrruu5[2].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(true);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou6()
    {
        sayilarortadogrruu6[0].SetActive(true);
        sayilarortadogrruu6[1].SetActive(true);


        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(true);
        sayilarortapaneelll[7].SetActive(false);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortadou7()
    {
        sayilarortadogrruu7[0].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(true);
        sayilarortapuannıı = sayilarortapuannıı + 10;
        sayilarortadogrrusuu = sayilarortadogrrusuu + 1;
    }
    public void sayilarortayais1()
    {
        sayilarortayanlliss1[0].SetActive(true);
        sayilarortayanlliss1[1].SetActive(true);
        sayilarortayanlliss1[2].SetActive(true);
        sayilarortayanlliss1[3].SetActive(true);
        sayilarortayanlliss1[4].SetActive(true);
        sayilarortayanlliss1[5].SetActive(true);
        sayilarortayanlliss1[6].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(true);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais2()
    {
        sayilarortayanlliss2[0].SetActive(true);
        sayilarortayanlliss2[1].SetActive(true);
        sayilarortayanlliss2[2].SetActive(true);
        sayilarortayanlliss2[3].SetActive(true);
        sayilarortayanlliss2[4].SetActive(true);
        sayilarortayanlliss2[5].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(true);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais3()
    {
        sayilarortayanlliss3[0].SetActive(true);
        sayilarortayanlliss3[1].SetActive(true);
        sayilarortayanlliss3[2].SetActive(true);
        sayilarortayanlliss3[3].SetActive(true);
        sayilarortayanlliss3[4].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(true);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais4()
    {
        sayilarortayanlliss4[0].SetActive(true);
        sayilarortayanlliss4[1].SetActive(true);
        sayilarortayanlliss4[2].SetActive(true);
        sayilarortayanlliss4[3].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(true);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais5()
    {
        sayilarortayanlliss5[0].SetActive(true);
        sayilarortayanlliss5[1].SetActive(true);
        sayilarortayanlliss5[2].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(true);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais6()
    {
        sayilarortayanlliss6[0].SetActive(true);
        sayilarortayanlliss6[1].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(true);
        sayilarortapaneelll[7].SetActive(false);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    public void sayilarortayais7()
    {
        sayilarortayanlliss7[0].SetActive(true);

        sayilarortapaneelll[0].SetActive(false);
        sayilarortapaneelll[1].SetActive(false);
        sayilarortapaneelll[2].SetActive(false);
        sayilarortapaneelll[3].SetActive(false);
        sayilarortapaneelll[4].SetActive(false);
        sayilarortapaneelll[5].SetActive(false);
        sayilarortapaneelll[6].SetActive(false);
        sayilarortapaneelll[7].SetActive(true);

        sayilarortayannlisii = sayilarortayannlisii + 1;
    }
    void Update () {
        if (sayilarortapuannıı > PlayerPrefs.GetFloat("sayilarorta"))
        {

            PlayerPrefs.SetFloat("sayilarorta", sayilarortapuannıı);

        }
        sayilarortarekkorr.text = PlayerPrefs.GetFloat("sayilarorta").ToString();
        sayilarortadogrrularr.text = sayilarortadogrrusuu.ToString();
        sayilarortapuuann.text = sayilarortapuannıı.ToString();
        sayilarortayanllislarr.text = sayilarortayannlisii.ToString();
    }
}

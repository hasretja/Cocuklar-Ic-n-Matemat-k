using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ortat : MonoBehaviour {
    public GameObject[] dogruu1;
    public GameObject[] yanliss1;
    public GameObject[] dogruu2;
    public GameObject[] yanliss2;
    public GameObject[] dogruu3;
    public GameObject[] yanliss3;
    public GameObject[] dogruu4;
    public GameObject[] yanliss4;
    public GameObject[] dogruu5;
    public GameObject[] yanliss5;
    public GameObject[] dogruu6;
    public GameObject[] yanliss6;
    public GameObject[] dogruu7;
    public GameObject[] yanliss7;
    public GameObject[] panelll;
    public Text puann;
    public Text dogrularr;
    public Text yanlislarr;
    public Text rekorr;
    public float pu;
    public float dogrusuu;
    public float yanlisii;
    void Start () {
        dogruu1[0].SetActive(false);
        dogruu1[1].SetActive(false);
        dogruu1[2].SetActive(false);
        dogruu1[3].SetActive(false);
        dogruu1[4].SetActive(false);
        dogruu1[5].SetActive(false);
        dogruu1[6].SetActive(false);

        yanliss1[0].SetActive(false);
        yanliss1[1].SetActive(false);
        yanliss1[2].SetActive(false);
        yanliss1[3].SetActive(false);
        yanliss1[4].SetActive(false);
        yanliss1[5].SetActive(false);
        yanliss1[6].SetActive(false);

        dogruu2[0].SetActive(false);
        dogruu2[1].SetActive(false);
        dogruu2[2].SetActive(false);
        dogruu2[3].SetActive(false);
        dogruu2[4].SetActive(false);
        dogruu2[5].SetActive(false);



        yanliss2[0].SetActive(false);
        yanliss2[1].SetActive(false);
        yanliss2[2].SetActive(false);
        yanliss2[3].SetActive(false);
        yanliss2[4].SetActive(false);
        yanliss2[5].SetActive(false);


        dogruu3[0].SetActive(false);
        dogruu3[1].SetActive(false);
        dogruu3[2].SetActive(false);
        dogruu3[3].SetActive(false);
        dogruu3[4].SetActive(false);


        yanliss3[0].SetActive(false);
        yanliss3[1].SetActive(false);
        yanliss3[2].SetActive(false);
        yanliss3[3].SetActive(false);
        yanliss3[4].SetActive(false);

        dogruu4[0].SetActive(false);
        dogruu4[1].SetActive(false);
        dogruu4[2].SetActive(false);
        dogruu4[3].SetActive(false);


        yanliss4[0].SetActive(false);
        yanliss4[1].SetActive(false);
        yanliss4[2].SetActive(false);
        yanliss4[3].SetActive(false);


        dogruu5[0].SetActive(false);
        dogruu5[1].SetActive(false);
        dogruu5[2].SetActive(false);


        yanliss5[0].SetActive(false);
        yanliss5[1].SetActive(false);
        yanliss5[2].SetActive(false);


        dogruu6[0].SetActive(false);
        dogruu6[1].SetActive(false);

        yanliss6[0].SetActive(false);
        yanliss6[1].SetActive(false);

        dogruu7[0].SetActive(false);

        yanliss7[0].SetActive(false);
    }
    public void dogru1()
    {
        dogruu1[0].SetActive(true);
        dogruu1[1].SetActive(true);
        dogruu1[2].SetActive(true);
        dogruu1[3].SetActive(true);
        dogruu1[4].SetActive(true);
        dogruu1[5].SetActive(true);
        dogruu1[6].SetActive(true);

        yanliss1[0].SetActive(false);
        yanliss1[1].SetActive(false);
        yanliss1[2].SetActive(false);
        yanliss1[3].SetActive(false);
        yanliss1[4].SetActive(false);
        yanliss1[5].SetActive(false);
        yanliss1[6].SetActive(false);

        panelll[0].SetActive(false);
        panelll[1].SetActive(true);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru2()
    {
        dogruu2[0].SetActive(true);
        dogruu2[1].SetActive(true);
        dogruu2[2].SetActive(true);
        dogruu2[3].SetActive(true);
        dogruu2[4].SetActive(true);
        dogruu2[5].SetActive(true);
        

        yanliss2[0].SetActive(false);
        yanliss2[1].SetActive(false);
        yanliss2[2].SetActive(false);
        yanliss2[3].SetActive(false);
        yanliss2[4].SetActive(false);
        yanliss2[5].SetActive(false);
        

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(true);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru3()
    {
        dogruu3[0].SetActive(true);
        dogruu3[1].SetActive(true);
        dogruu3[2].SetActive(true);
        dogruu3[3].SetActive(true);
        dogruu3[4].SetActive(true);
        

        yanliss3[0].SetActive(false);
        yanliss3[1].SetActive(false);
        yanliss3[2].SetActive(false);
        yanliss3[3].SetActive(false);
        yanliss3[4].SetActive(false);
        

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(true);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru4()
    {
        dogruu4[0].SetActive(true);
        dogruu4[1].SetActive(true);
        dogruu4[2].SetActive(true);
        dogruu4[3].SetActive(true);
        


        yanliss4[0].SetActive(false);
        yanliss4[1].SetActive(false);
        yanliss4[2].SetActive(false);
        yanliss4[3].SetActive(false);
       


        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(true);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru5()
    {
        dogruu5[0].SetActive(true);
        dogruu5[1].SetActive(true);
        dogruu5[2].SetActive(true);

        yanliss5[0].SetActive(false);
        yanliss5[1].SetActive(false);
        yanliss5[2].SetActive(false);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(true);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru6()
    {
        dogruu6[0].SetActive(true);
        dogruu6[1].SetActive(true);

        yanliss6[0].SetActive(false);
        yanliss6[1].SetActive(false);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(true);
        panelll[7].SetActive(false);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void dogru7()
    {
        dogruu7[0].SetActive(true);

        yanliss7[0].SetActive(false);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(true);
        pu = pu + 10;
        dogrusuu = dogrusuu + 1;
    }
    public void yanlis1()
    {
        dogruu1[0].SetActive(false);
        dogruu1[1].SetActive(false);
        dogruu1[2].SetActive(false);
        dogruu1[3].SetActive(false);
        dogruu1[4].SetActive(false);
        dogruu1[5].SetActive(false);
        dogruu1[6].SetActive(false);

        yanliss1[0].SetActive(true);
        yanliss1[1].SetActive(true);
        yanliss1[2].SetActive(true);
        yanliss1[3].SetActive(true);
        yanliss1[4].SetActive(true);
        yanliss1[5].SetActive(true);
        yanliss1[6].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(true);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis2()
    {
        dogruu2[0].SetActive(false);
        dogruu2[1].SetActive(false);
        dogruu2[2].SetActive(false);
        dogruu2[3].SetActive(false);
        dogruu2[4].SetActive(false);
        dogruu2[5].SetActive(false);
        

        yanliss2[0].SetActive(true);
        yanliss2[1].SetActive(true);
        yanliss2[2].SetActive(true);
        yanliss2[3].SetActive(true);
        yanliss2[4].SetActive(true);
        yanliss2[5].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(true);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis3()
    {
        dogruu3[0].SetActive(false);
        dogruu3[1].SetActive(false);
        dogruu3[2].SetActive(false);
        dogruu3[3].SetActive(false);
        dogruu3[4].SetActive(false);

        yanliss3[0].SetActive(true);
        yanliss3[1].SetActive(true);
        yanliss3[2].SetActive(true);
        yanliss3[3].SetActive(true);
        yanliss3[4].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(true);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis4()
    {
        dogruu4[0].SetActive(false);
        dogruu4[1].SetActive(false);
        dogruu4[2].SetActive(false);
        dogruu4[3].SetActive(false);

        yanliss4[0].SetActive(true);
        yanliss4[1].SetActive(true);
        yanliss4[2].SetActive(true);
        yanliss4[3].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(true);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis5()
    {
        dogruu5[0].SetActive(false);
        dogruu5[1].SetActive(false);
        dogruu5[2].SetActive(false);

        yanliss5[0].SetActive(true);
        yanliss5[1].SetActive(true);
        yanliss5[2].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(true);
        panelll[6].SetActive(false);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis6()
    {
        dogruu6[0].SetActive(false);
        dogruu6[1].SetActive(false);

        yanliss6[0].SetActive(true);
        yanliss6[1].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(true);
        panelll[7].SetActive(false);

        yanlisii = yanlisii + 1;
    }
    public void yanlis7()
    {
        dogruu7[0].SetActive(false);

        yanliss7[0].SetActive(true);

        panelll[0].SetActive(false);
        panelll[1].SetActive(false);
        panelll[2].SetActive(false);
        panelll[3].SetActive(false);
        panelll[4].SetActive(false);
        panelll[5].SetActive(false);
        panelll[6].SetActive(false);
        panelll[7].SetActive(true);

        yanlisii = yanlisii + 1;
    }
    void Update () {
        if (pu > PlayerPrefs.GetFloat("REK4"))
        {

            PlayerPrefs.SetFloat("REK4", pu);

        }
        rekorr.text = PlayerPrefs.GetFloat("REK4").ToString();
        dogrularr.text = dogrusuu.ToString();
        puann.text = pu.ToString();
        yanlislarr.text = yanlisii.ToString();

    }
}

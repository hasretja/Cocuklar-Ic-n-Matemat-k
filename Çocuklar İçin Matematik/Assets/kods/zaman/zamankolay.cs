using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zamankolay : MonoBehaviour {
    public GameObject[] druuuu1;
    public GameObject[] ynlissss1;
    public GameObject[] druuuu2;
    public GameObject[] ynlissss2;
    public GameObject[] druuuu3;
    public GameObject[] ynlissss3;
    public GameObject[] druuuu4;
    public GameObject[] ynlissss4;
    public GameObject[] druuuu5;
    public GameObject[] ynlissss5;
    public GameObject[] paelllll;
    public Text pannnn;
    public Text drularrrr;
    public Text ynlislarrrr;
    public Text rorrrr;
    public float panıııı;
    public float dgrusuuuu;
    public float ynlisiiii;
    void Start () {
        druuuu1[0].SetActive(false);
        druuuu1[1].SetActive(false);
        druuuu1[2].SetActive(false);
        druuuu1[3].SetActive(false);
        druuuu1[4].SetActive(false);

        ynlissss1[0].SetActive(false);
        ynlissss1[1].SetActive(false);
        ynlissss1[2].SetActive(false);
        ynlissss1[3].SetActive(false);
        ynlissss1[4].SetActive(false);

        druuuu2[0].SetActive(false);
        druuuu2[1].SetActive(false);
        druuuu2[2].SetActive(false);
        druuuu2[3].SetActive(false);


        ynlissss2[0].SetActive(false);
        ynlissss2[1].SetActive(false);
        ynlissss2[2].SetActive(false);
        ynlissss2[3].SetActive(false);


        druuuu3[0].SetActive(false);
        druuuu3[1].SetActive(false);
        druuuu3[2].SetActive(false);

        ynlissss3[0].SetActive(false);
        ynlissss3[1].SetActive(false);
        ynlissss3[2].SetActive(false);


        druuuu4[0].SetActive(false);
        druuuu4[1].SetActive(false);

        ynlissss4[0].SetActive(false);
        ynlissss4[1].SetActive(false);

        druuuu5[0].SetActive(false);

        ynlissss5[0].SetActive(false);
    }
    public void dg1()
    {
        druuuu1[0].SetActive(true);
        druuuu1[1].SetActive(true);
        druuuu1[2].SetActive(true);
        druuuu1[3].SetActive(true);
        druuuu1[4].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(true);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        panıııı = panıııı + 10;
        dgrusuuuu = dgrusuuuu + 1;
    }
    public void dg2()
    {
        druuuu2[0].SetActive(true);
        druuuu2[1].SetActive(true);
        druuuu2[2].SetActive(true);
        druuuu2[3].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(true);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        panıııı = panıııı + 10;
        dgrusuuuu = dgrusuuuu + 1;
    }
    public void dg3()
    {
        druuuu3[0].SetActive(true);
        druuuu3[1].SetActive(true);
        druuuu3[2].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(true);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        panıııı = panıııı + 10;
        dgrusuuuu = dgrusuuuu + 1;
    }
    public void dg4()
    {
        druuuu4[0].SetActive(true);
        druuuu4[1].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(true);
        paelllll[5].SetActive(false);

        panıııı = panıııı + 10;
        dgrusuuuu = dgrusuuuu + 1;
    }
    public void dg5()
    {
        druuuu5[0].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(true);

        panıııı = panıııı + 10;
        dgrusuuuu = dgrusuuuu + 1;
    }
    public void yn1()
    {
        ynlissss1[0].SetActive(true);
        ynlissss1[1].SetActive(true);
        ynlissss1[2].SetActive(true);
        ynlissss1[3].SetActive(true);
        ynlissss1[4].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(true);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        ynlisiiii = ynlisiiii + 1;
    }
    public void yn2()
    {
        ynlissss2[0].SetActive(true);
        ynlissss2[1].SetActive(true);
        ynlissss2[2].SetActive(true);
        ynlissss2[3].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(true);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        ynlisiiii = ynlisiiii + 1;
    }
    public void yn3()
    {
        ynlissss3[0].SetActive(true);
        ynlissss3[1].SetActive(true);
        ynlissss3[2].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(true);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(false);

        ynlisiiii = ynlisiiii + 1;
    }
    public void yn4()
    {
        ynlissss4[0].SetActive(true);
        ynlissss4[1].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(true);
        paelllll[5].SetActive(false);

        ynlisiiii = ynlisiiii + 1;
    }
    public void yn5()
    {
        ynlissss5[0].SetActive(true);

        paelllll[0].SetActive(false);
        paelllll[1].SetActive(false);
        paelllll[2].SetActive(false);
        paelllll[3].SetActive(false);
        paelllll[4].SetActive(false);
        paelllll[5].SetActive(true);

        ynlisiiii = ynlisiiii + 1;
    }
    void Update () {
        if (panıııı > PlayerPrefs.GetFloat("R"))
        {

            PlayerPrefs.SetFloat("R", panıııı);

        }
        rorrrr.text = PlayerPrefs.GetFloat("R").ToString();
        drularrrr.text = dgrusuuuu.ToString();
        pannnn.text = panıııı.ToString();
        ynlislarrrr.text = ynlisiiii.ToString();
    }
}


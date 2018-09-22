using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kesirlerkolay : MonoBehaviour {
    public GameObject[] dogruuuu1;
    public GameObject[] yanlissss1;
    public GameObject[] dogruuuu2;
    public GameObject[] yanlissss2;
    public GameObject[] dogruuuu3;
    public GameObject[] yanlissss3;
    public GameObject[] dogruuuu4;
    public GameObject[] yanlissss4;
    public GameObject[] dogruuuu5;
    public GameObject[] yanlissss5;
    public GameObject[] panelllll;
    public Text puannnn;
    public Text dogrularrrr;
    public Text yanlislarrrr;
    public Text rekorrrr;
    public float puanıııı;
    public float dogrusuuuu;
    public float yanlisiiii;
    void Start () {
        dogruuuu1[0].SetActive(false);
        dogruuuu1[1].SetActive(false);
        dogruuuu1[2].SetActive(false);
        dogruuuu1[3].SetActive(false);
        dogruuuu1[4].SetActive(false);

        yanlissss1[0].SetActive(false);
        yanlissss1[1].SetActive(false);
        yanlissss1[2].SetActive(false);
        yanlissss1[3].SetActive(false);
        yanlissss1[4].SetActive(false);

        dogruuuu2[0].SetActive(false);
        dogruuuu2[1].SetActive(false);
        dogruuuu2[2].SetActive(false);
        dogruuuu2[3].SetActive(false);
        

        yanlissss2[0].SetActive(false);
        yanlissss2[1].SetActive(false);
        yanlissss2[2].SetActive(false);
        yanlissss2[3].SetActive(false);
       

        dogruuuu3[0].SetActive(false);
        dogruuuu3[1].SetActive(false);
        dogruuuu3[2].SetActive(false);
       
        yanlissss3[0].SetActive(false);
        yanlissss3[1].SetActive(false);
        yanlissss3[2].SetActive(false);
      

        dogruuuu4[0].SetActive(false);
        dogruuuu4[1].SetActive(false);

        yanlissss4[0].SetActive(false);
        yanlissss4[1].SetActive(false);

        dogruuuu5[0].SetActive(false);

        yanlissss5[0].SetActive(false);
    }
	public void dog1()
    {
        dogruuuu1[0].SetActive(true);
        dogruuuu1[1].SetActive(true);
        dogruuuu1[2].SetActive(true);
        dogruuuu1[3].SetActive(true);
        dogruuuu1[4].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(true);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        puanıııı = puanıııı + 10;
        dogrusuuuu = dogrusuuuu + 1;
    }
    public void dog2()
    {
        dogruuuu2[0].SetActive(true);
        dogruuuu2[1].SetActive(true);
        dogruuuu2[2].SetActive(true);
        dogruuuu2[3].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(true);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        puanıııı = puanıııı + 10;
        dogrusuuuu = dogrusuuuu + 1;
    }
    public void dog3()
    {
        dogruuuu3[0].SetActive(true);
        dogruuuu3[1].SetActive(true);
        dogruuuu3[2].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(true);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        puanıııı = puanıııı + 10;
        dogrusuuuu = dogrusuuuu + 1;
    }
    public void dog4()
    {
        dogruuuu4[0].SetActive(true);
        dogruuuu4[1].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(true);
        panelllll[5].SetActive(false);

        puanıııı = puanıııı + 10;
        dogrusuuuu = dogrusuuuu + 1;
    }
    public void dog5()
    {
        dogruuuu5[0].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(true);

        puanıııı = puanıııı + 10;
        dogrusuuuu = dogrusuuuu + 1;
    }
    public void yan1()
    {
        yanlissss1[0].SetActive(true);
        yanlissss1[1].SetActive(true);
        yanlissss1[2].SetActive(true);
        yanlissss1[3].SetActive(true);
        yanlissss1[4].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(true);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        yanlisiiii = yanlisiiii + 1;
    }
    public void yan2()
    {
        yanlissss2[0].SetActive(true);
        yanlissss2[1].SetActive(true);
        yanlissss2[2].SetActive(true);
        yanlissss2[3].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(true);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        yanlisiiii = yanlisiiii + 1;
    }
    public void yan3()
    {
        yanlissss3[0].SetActive(true);
        yanlissss3[1].SetActive(true);
        yanlissss3[2].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(true);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(false);

        yanlisiiii = yanlisiiii + 1;
    }
    public void yan4()
    {
        yanlissss4[0].SetActive(true);
        yanlissss4[1].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(true);
        panelllll[5].SetActive(false);

        yanlisiiii = yanlisiiii + 1;
    }
    public void yan5()
    {
        yanlissss5[0].SetActive(true);

        panelllll[0].SetActive(false);
        panelllll[1].SetActive(false);
        panelllll[2].SetActive(false);
        panelllll[3].SetActive(false);
        panelllll[4].SetActive(false);
        panelllll[5].SetActive(true);

        yanlisiiii = yanlisiiii + 1;
    }
    void Update () {
        if (puanıııı > PlayerPrefs.GetFloat("Rek6"))
        {

            PlayerPrefs.SetFloat("Rek6", puanıııı);

        }
        rekorrrr.text = PlayerPrefs.GetFloat("Rek6").ToString();
        dogrularrrr.text = dogrusuuuu.ToString();
        puannnn.text = puanıııı.ToString();
        yanlislarrrr.text = yanlisiiii.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sayilarkolay : MonoBehaviour {
    public GameObject[] kolaysayidogruuuu1;
    public GameObject[] kolaysayiyanlissss1;
    public GameObject[] kolaysayidogruuuu2;
    public GameObject[] kolaysayiyanlissss2;
    public GameObject[] kolaysayidogruuuu3;
    public GameObject[] kolaysayiyanlissss3;
    public GameObject[] kolaysayidogruuuu4;
    public GameObject[] kolaysayiyanlissss4;
    public GameObject[] kolaysayidogruuuu5;
    public GameObject[] kolaysayiyanlissss5;
    public GameObject[] kolaysayipanelllll;
    public Text kolaysayipuannnn;
    public Text kolaysayidogrularrrr;
    public Text kolaysayiyanlislarrrr;
    public Text kolaysayirekorrrr;
    public float kolaysayipuanıııı;
    public float kolaysayidogrusuuuu;
    public float kolaysayiyanlisiiii;
    void Start () {
        kolaysayidogruuuu1[0].SetActive(false);
        kolaysayidogruuuu1[1].SetActive(false);
        kolaysayidogruuuu1[2].SetActive(false);
        kolaysayidogruuuu1[3].SetActive(false);
        kolaysayidogruuuu1[4].SetActive(false);

        kolaysayiyanlissss1[0].SetActive(false);
        kolaysayiyanlissss1[1].SetActive(false);
        kolaysayiyanlissss1[2].SetActive(false);
        kolaysayiyanlissss1[3].SetActive(false);
        kolaysayiyanlissss1[4].SetActive(false);

        kolaysayidogruuuu2[0].SetActive(false);
        kolaysayidogruuuu2[1].SetActive(false);
        kolaysayidogruuuu2[2].SetActive(false);
        kolaysayidogruuuu2[3].SetActive(false);


        kolaysayiyanlissss2[0].SetActive(false);
        kolaysayiyanlissss2[1].SetActive(false);
        kolaysayiyanlissss2[2].SetActive(false);
        kolaysayiyanlissss2[3].SetActive(false);


        kolaysayidogruuuu3[0].SetActive(false);
        kolaysayidogruuuu3[1].SetActive(false);
        kolaysayidogruuuu3[2].SetActive(false);

        kolaysayiyanlissss3[0].SetActive(false);
        kolaysayiyanlissss3[1].SetActive(false);
        kolaysayiyanlissss3[2].SetActive(false);


        kolaysayidogruuuu4[0].SetActive(false);
        kolaysayidogruuuu4[1].SetActive(false);

        kolaysayiyanlissss4[0].SetActive(false);
        kolaysayiyanlissss4[1].SetActive(false);

        kolaysayidogruuuu5[0].SetActive(false);

        kolaysayiyanlissss5[0].SetActive(false);
    }
    public void kolaysayidog1()
    {
        kolaysayidogruuuu1[0].SetActive(true);
        kolaysayidogruuuu1[1].SetActive(true);
        kolaysayidogruuuu1[2].SetActive(true);
        kolaysayidogruuuu1[3].SetActive(true);
        kolaysayidogruuuu1[4].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(true);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayipuanıııı = kolaysayipuanıııı + 10;
        kolaysayidogrusuuuu = kolaysayidogrusuuuu + 1;
    }
    public void kolaysayidog2()
    {
        kolaysayidogruuuu2[0].SetActive(true);
        kolaysayidogruuuu2[1].SetActive(true);
        kolaysayidogruuuu2[2].SetActive(true);
        kolaysayidogruuuu2[3].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(true);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayipuanıııı = kolaysayipuanıııı + 10;
        kolaysayidogrusuuuu = kolaysayidogrusuuuu + 1;
    }
    public void kolaysayidog3()
    {
        kolaysayidogruuuu3[0].SetActive(true);
        kolaysayidogruuuu3[1].SetActive(true);
        kolaysayidogruuuu3[2].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(true);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayipuanıııı = kolaysayipuanıııı + 10;
        kolaysayidogrusuuuu = kolaysayidogrusuuuu + 1;
    }
    public void kolaysayidog4()
    {
        kolaysayidogruuuu4[0].SetActive(true);
        kolaysayidogruuuu4[1].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(true);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayipuanıııı = kolaysayipuanıııı + 10;
        kolaysayidogrusuuuu = kolaysayidogrusuuuu + 1;
    }
    public void kolaysayidog5()
    {
        kolaysayidogruuuu5[0].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(true);

        kolaysayipuanıııı = kolaysayipuanıııı + 10;
        kolaysayidogrusuuuu = kolaysayidogrusuuuu + 1;
    }
    public void kolaysayiyan1()
    {
        kolaysayiyanlissss1[0].SetActive(true);
        kolaysayiyanlissss1[1].SetActive(true);
        kolaysayiyanlissss1[2].SetActive(true);
        kolaysayiyanlissss1[3].SetActive(true);
        kolaysayiyanlissss1[4].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(true);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayiyanlisiiii = kolaysayiyanlisiiii + 1;
    }
    public void kolaysayiyan2()
    {
        kolaysayiyanlissss2[0].SetActive(true);
        kolaysayiyanlissss2[1].SetActive(true);
        kolaysayiyanlissss2[2].SetActive(true);
        kolaysayiyanlissss2[3].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(true);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayiyanlisiiii = kolaysayiyanlisiiii + 1;
    }
    public void kolaysayiyan3()
    {
        kolaysayiyanlissss3[0].SetActive(true);
        kolaysayiyanlissss3[1].SetActive(true);
        kolaysayiyanlissss3[2].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(true);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayiyanlisiiii = kolaysayiyanlisiiii + 1;
    }
    public void kolaysayiyan4()
    {
        kolaysayiyanlissss4[0].SetActive(true);
        kolaysayiyanlissss4[1].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(true);
        kolaysayipanelllll[5].SetActive(false);

        kolaysayiyanlisiiii = kolaysayiyanlisiiii + 1;
    }
    public void kolaysayiyan5()
    {
        kolaysayiyanlissss5[0].SetActive(true);

        kolaysayipanelllll[0].SetActive(false);
        kolaysayipanelllll[1].SetActive(false);
        kolaysayipanelllll[2].SetActive(false);
        kolaysayipanelllll[3].SetActive(false);
        kolaysayipanelllll[4].SetActive(false);
        kolaysayipanelllll[5].SetActive(true);

        kolaysayiyanlisiiii = kolaysayiyanlisiiii + 1;
    }
    void Update () {
        if (kolaysayipuanıııı > PlayerPrefs.GetFloat("kolaysayi"))
        {

            PlayerPrefs.SetFloat("kolaysayi", kolaysayipuanıııı);

        }
        kolaysayirekorrrr.text = PlayerPrefs.GetFloat("kolaysayi").ToString();
        kolaysayidogrularrrr.text = kolaysayidogrusuuuu.ToString();
        kolaysayipuannnn.text = kolaysayipuanıııı.ToString();
        kolaysayiyanlislarrrr.text = kolaysayiyanlisiiii.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bolumkods : MonoBehaviour {
    public void buton()
    {
        Application.LoadLevel(this.gameObject.name);
    }
}

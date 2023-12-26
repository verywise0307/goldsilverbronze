using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class NumberDirector : MonoBehaviour
{
    GameObject Number;
    int point;

    public void GetMandarin()
    {
        this.point += 1;

    }
    // Start is called before the first frame update
    void Start()
    {
        this.Number = GameObject.Find("Number");
    }


    // Update is called once per frame
    void Update()
    {
        this.Number.GetComponent<TextMeshProUGUI>().text = "point: " + this.point.ToString();
    }

    

}

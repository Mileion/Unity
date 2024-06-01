using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDiretor : MonoBehaviour
{
    GameObject timerText;
    GameObject PointText;
    float time = 30f;
    int point = 0;
    GameObject generator;

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.PointText = GameObject.Find("Point");
        this.generator = GameObject.Find("ItemGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        if (this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
        }
        else if(0<= this.time && this.time <5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 3);
        }
        else if (5 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.8f, -0.05f, 6);
        }
        else if (10 <= this.time && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.8f, -0.04f, 3);
        }
        else if (20 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(1f, -0.03f, 2);
        }
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.PointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + "point";
    }
}

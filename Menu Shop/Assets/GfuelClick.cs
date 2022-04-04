using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GfuelClick : MonoBehaviour
{

    public Image Gfuel;
    public Sprite Level1;
    public Sprite Level2;
    public Sprite Level3;
    public Sprite Level4;

    public int level = 1;
    public MoneyUpdate MU;

    public void ImageChange()
    {
        if (level == 1 && MU.pCash >= 10)
        {
            Gfuel.sprite = Level2;
            level = 2;
            MU.pCash -= 10;
            MU.TextCall();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

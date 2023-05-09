using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject bullet;
    public Image  but1,but2,but3,but4;
    // Start is called before the first frame update
    void Start()
    {
        bullet.active =(false);

    }

    // Update is called once per frame
    void Update()
    {
        //bullet.text = GameManager.bullet.ToString();
        if (GameManager.bullet == 1)
        {
            bullet.gameObject.active = (true);
            but1.gameObject.active = (true);
        }
        if (GameManager.bullet == 2) but2.gameObject.active = (true);
        if (GameManager.bullet == 3) but3.gameObject.active = (true);
        if (GameManager.bullet == 4) but4.gameObject.active = (true);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManger : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textmesh;
    public static TextManger textManager; //created a public instance of this class

    int score;

    public void IncreaseScore()
    {
        score++;
        textManager.textmesh.text = "Altcoin bag: " + score;
    }


    // Start is called before the first frame update
    void Start()
    {

        //null check 
        if(textManager == null)
        {
            textManager = this;
        }

        score = 0;
        textManager.textmesh.text = "Altcoin bag: " + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

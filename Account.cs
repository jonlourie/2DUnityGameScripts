using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enjin.SDK.Utility;
using Enjin.SDK.Template;
using Enjin.SDK.PusherClient;
using Enjin.SDK.GraphQL;
using Enjin.SDK.DataTypes;
using Enjin.SDK.Core;
using TMPro;
using UnityEngine.UI;






public class Account : MonoBehaviour
{

    public GameObject emailInput; //in order to get the input fields for these UI pieces we needed to import the UI namespace not text mesh pro which I think is different thats more for dynamic texts not UI buttons 
    public GameObject passwordInput;

    private readonly string PLATFORM_URL = "https://kovan.cloud.enjin.io/"; //url to initialize 

    EnjinPlatform enjinPlatform;
    EnjinRequests login;
    EnjinIdentities users;

    // Start is called before the first frame update
    void Start()
    {
        
        enjinPlatform.InitializePlatform();

        //InitializePlatform(PLATFORM_URL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async public void Login()
    {
        string email = emailInput.GetComponent<InputField>().text;
        string password = passwordInput.GetComponent<InputField>().text;
        
        //jinUsers users = await users. supposed to get the user identity here
        //basically I need enjin documentation on sdk
       
        //users.Get()
    }
}

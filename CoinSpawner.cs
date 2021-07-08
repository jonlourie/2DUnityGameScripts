using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField]
    private float timeBetweenSpawn;

    [SerializeField]
    private GameObject prefab;

    private float timeToNextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeToNextSpawn = timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        //very clever way to program in time using the update method



        timeToNextSpawn = timeToNextSpawn - Time.deltaTime; //subtrtact the time every frame from the time we inputed in or spawn till its 0 again

        if (timeToNextSpawn <= 0.0f)
        {
            Spawn();
            
            timeToNextSpawn = timeBetweenSpawn; //we redo the time to next spawn so it is eqaul agian to the next one

        }




    }

    void Spawn()
    {
        for (int i=0; i<30; i++)
        Instantiate(prefab, new Vector2(-10 + 0.7f * i, 15), Quaternion.identity); //this will basically spawn the coins in a row using the variable i as a way to consitantly increase the x access spawning point
        
    }


}

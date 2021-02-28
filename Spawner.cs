using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1;
    public float height = 1;
    private float timer = 0;
    public GameObject Pipes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipes = Instantiate(Pipes);
            newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
            Destroy(newPipes, 10);
            timer = 0; 
        }

        timer += Time.deltaTime;
        
    }
}

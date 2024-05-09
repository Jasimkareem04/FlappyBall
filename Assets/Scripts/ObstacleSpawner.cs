using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // public GameObject[] section;
    public GameObject myObstacle;
    public int xPos = 10;
    public float ypos = 1;
    public bool creatingSection = false; 
    public int SecNum;
    float position;

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true ;
            StartCoroutine(GenerateSection());
        }

        IEnumerator GenerateSection()
        {
            // SecNum = Random.Range(0,5);
            // Instantiate(section[SecNum], new  Vector3(xPos,0,0),Quaternion.identity);
            // xPos += 10;
            // yield return //new WaitForSeconds(1);
            // creatingSection = true ;
            position = Random.Range(0.68f,2f);
            transform.position = new Vector3(xPos,position,0);
            Instantiate(myObstacle,transform.position,transform.rotation);
            xPos += 10;
            yield return //new WaitForSeconds(1);
            creatingSection = true ;

        }
       
    }
}

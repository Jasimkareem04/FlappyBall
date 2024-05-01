using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int xPos = 50 ;
    public bool creatingSection = false; 
    public int SecNum;

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
            SecNum = Random.Range(0,3);
            Instantiate(section[SecNum], new Vector3(xPos, 0, 0),Quaternion.identity);
            xPos += 50;
            yield return new WaitForSeconds(2);
            creatingSection = false ;
        }
    }
}

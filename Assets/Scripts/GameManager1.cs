using UnityEngine.SceneManagement ;
using UnityEngine;
using System.Runtime.InteropServices;

public class GameManager1 : MonoBehaviour
{
   public void EndGame()
   {
    Debug.Log("Game Over");
    Invoke("Restart",1);
   }

   void Restart()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   
}
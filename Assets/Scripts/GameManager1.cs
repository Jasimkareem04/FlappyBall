using UnityEngine.SceneManagement ;
using UnityEngine;
using System.Runtime.InteropServices;

public class GameManager1 : MonoBehaviour
{
   public GameObject GameOverUI;
   private void Start() {
      GameOverUI.SetActive(false);
   }
   public void EndGame()
   {
    Debug.Log("Game Over");
    GameOverUI.SetActive(true);
   //  Invoke("Restart",1);
   }

   public void Restart()
   {
      GameOverUI.SetActive(false);
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   
}
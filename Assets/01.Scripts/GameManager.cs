using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   private void Awake()
   {
      NextScene();
   }

   public void NextScene()
   {
      SceneManager.LoadScene("02.GameScene", LoadSceneMode.Additive);
   }

   public void EndScene()
   {
      SceneManager.LoadScene("03.EndScene", LoadSceneMode.Additive);

   }
}

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
   
   private void NextScene()
   {
      SceneManager.LoadScene("02.GameScene", LoadSceneMode.Additive);
   }

   private void EndScene()
   {
      SceneManager.LoadScene("03.EndScene", LoadSceneMode.Additive);

   }
}

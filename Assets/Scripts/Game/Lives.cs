using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

/*
 Code (csharp):
  
 private int currentHealth;
  
 public void TakeDamage(int damage)
 {
     currentHealth -= damage;
     if (currentHealth <= 0)
     {
         StartCoroutine(Die());
     }
 }
  
 private IEnumerator Die()
 {
     PlayAnimation(GlobalSettings.animDeath1, WrapeMode.ClampForever);
     yield return new WaitForSeconds(gameObject, GlobalSettings.animDeath1.length);
     Destroy(gameObject);
 }
*/

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    private void OnDestroy()
    {
        /*ThreadWork t = new ThreadWork();
        Thread thread = new Thread(ThreadWork.wait);
        thread.Start();

        while (!t.getChangeScene())
        {
            Debug.Log("Running thread");
        }*/
       new WaitForSeconds(5.0f);
        SceneManager.LoadScene("GameOver");
    }
}
/*
public class ThreadWork
{
    private static bool changeScene = false;

    public ThreadWork()
    {
    }

    public bool getChangeScene()
    {
        return changeScene;
    }

    public static void wait()
    {
        new WaitForSeconds(10.0f);
        changeScene = true;
    }
}
*/
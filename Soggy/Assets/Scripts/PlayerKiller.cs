using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKiller : MonoBehaviour
{
    //public string changeToScene;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3)
            SceneManager.LoadScene(0);
        if (transform.position.y < -9)
            SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}

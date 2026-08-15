using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Scale(float scale)
    {
        transform.localScale = new Vector2(1/scale, 1*scale);
    }

    public void Scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

    public void LoadScene(string scene)
    {
        LoadSceneByName(scene);
    }
    public IEnumerator LoadSceneByName(string scene)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(scene);
    }
}

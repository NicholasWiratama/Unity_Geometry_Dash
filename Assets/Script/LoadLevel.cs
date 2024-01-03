using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    Image _loadingBar;

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("Title Screen");

        while (!loadLevel.isDone)
        {
            _loadingBar.fillAmount = Mathf.Clamp01(loadLevel.progress / .9f);
            yield return null;
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LoadNextLevel());
    }

    // Update is called once per frame
   
}

using UnityEngine;
using System.Collections;

//original source from https://answers.unity.com/questions/1432380/im-trying-to-toggle-something.html
public class PauseController : MonoBehaviour
{
    public Transform canvas;

    // Update is called once per frame
    void Start() {
        canvas.gameObject.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
    }

    public void Pause() {
        if (canvas.gameObject.activeInHierarchy == false) {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        } else {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
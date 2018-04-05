using UnityEngine;

public class Menu : MonoBehaviour {
    public void ToggleMenu(GameObject obj)
    {
        obj.SetActive(!obj.active);
    }

    public void TurnOffGame()
    {
        Application.Quit();
    }
}

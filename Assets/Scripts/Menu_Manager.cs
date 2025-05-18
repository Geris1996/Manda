using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    public void StartGameWith2Players()
    {
        Game_Manager.playerCount = 2;
        SceneManager.LoadScene("SampleScene"); // Имя твоей игровой сцены
    }

    public void StartGameWith4Players()
    {
        Game_Manager.playerCount = 4;
        SceneManager.LoadScene("SampleScene");
    }
}

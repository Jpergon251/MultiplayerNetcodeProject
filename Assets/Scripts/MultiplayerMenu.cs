using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class MultiplayerMenu : MonoBehaviour
{
    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        NetworkManager.Singleton.SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
        
        Debug.Log("Host Iniciado");
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("CLiente Iniciado");
        // El cliente no carga la escena manualmente, el servidor lo sincroniza automáticamente
    }
}
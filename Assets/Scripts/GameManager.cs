using Photon.Pun;
using UnityEngine.SceneManagement;
namespace NEW.NAMESPACE.COM
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        /// <summary>
        /// Called when the local player left the room. We need to load the launcher scene.
    /// </summary>
 public override void OnLeftRoom()
        {
            SceneManager.LoadScene(0);
        }
        public void LeaveRoom()
        {
            PhotonNetwork.LeaveRoom();
        }
    }
}

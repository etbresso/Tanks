using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class TankLobbyHookOnline : Prototype.NetworkLobby.LobbyHook 
{
    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
        if (lobbyPlayer == null)
            return;

		Prototype.NetworkLobby.LobbyPlayer lp = lobbyPlayer.GetComponent<Prototype.NetworkLobby.LobbyPlayer>();

        if(lp != null)
            GameManagerOnline.AddTank(gamePlayer, lp.slot, lp.playerColor, lp.nameInput.text, lp.playerControllerId);
    }
}

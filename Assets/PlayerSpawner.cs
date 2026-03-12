using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public void PlayerJoined(PlayerRef player)
    {
      if(player == Runner.LocalPlayer)
        {
            
            Runner.Spawn(_playerPrefab, Vector3.up, Quaternion.identity ,Runner.LocalPlayer);

        }
    }
[SerializeField] private GameObject _playerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private bool IsFlipped;
    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
       if(Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            if (IsFlipped == false) {
                _spriteRenderer.flipX = true;
                IsFlipped = true;
            }
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
             if (IsFlipped == true) {
                _spriteRenderer.flipX = false;
                IsFlipped = false;
            }
        }
        if(Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space)) {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0) {
            _numSeedsPlanted++;
            _numSeedsLeft--;
            Vector3 plantSpawnPosition = new Vector3(_playerTransform.position.x,_playerTransform.position.y,0);
            Instantiate(_plantPrefab, plantSpawnPosition, Quaternion.identity);
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}

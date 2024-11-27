using UnityEngine;
using UnityEngine.UI;

public class BGScript : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float _x;

    void Update()
    {

        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x * Time.deltaTime, 0), _img.uvRect.size);
    }
}
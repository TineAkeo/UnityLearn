using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 transformPosition = new Vector3(3, 4, 1);
    public Vector3 transformLocalScale = Vector3.one * 1.3f;
    public Color materialColor = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    void Start()
    {
        Material material = Renderer.material;
        transform.position = transformPosition;
        transform.localScale = transformLocalScale;
        material.color = materialColor;
        Tween.Position(transform, Vector3.zero, Vector3.up, 3f, 0f, Tween.EaseInOutStrong, Tween.LoopType.PingPong);
        Tween.Value(new Color(0.5f, 1.0f, 0.3f, 0.4f), new Color(1.0f, 1.0f, 1.0f,1.0f),ColorChangeCallback,5,0,Tween.EaseInOutStrong,Tween.LoopType.PingPong);
    }
    void ColorChangeCallback(Color color)
    {
        Material material = Renderer.material;
        material.color = color;
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}

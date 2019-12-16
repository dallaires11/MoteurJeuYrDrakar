using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]



public class CathoShader : MonoBehaviour
{
    [Range(0, 1)] public float verts_force = 0.0f;
    [Range(0, 1)] public float verts_force2 = 0.0f;
    [Range(-3, 20)] public float contrast = 0.0f;
    [Range(-200, 200)] public float brightness = 0.0f;
    public Shader shader;
    private Material _material;

    protected Material material
    {
        get
        {
            if (_material == null)
            {
                _material = new Material(shader);
                _material.hideFlags = HideFlags.HideAndDontSave;
            }
            return _material;
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (shader == null) return;
        Material mat = material;
        mat.SetFloat("_VertsColor", 1 - verts_force);
        mat.SetFloat("_VertsColor2", 1 - verts_force2);
        mat.SetFloat("_Br", brightness);
        mat.SetFloat("_Contrast", contrast);

        Graphics.Blit(source, destination, mat);
    }

    void OnDisable()
    {
        if (_material)
        {
            DestroyImmediate(_material);
        }
    }
}
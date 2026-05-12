using UnityEngine;
using UnityEngine.Events;

public class MeshButton : MonoBehaviour
{
<<<<<<< HEAD
    // Bu kýsýmlarý Inspector'dan sürükleyip baðlayacaðýz
    public GameManager gameManager;

    public enum ClickType { KahveSec, SekerArtir, AromaEkle }
    public ClickType neYapsin;

    public string kahveVeyaAromaAdi; // "Espresso" veya "Vanilya" gibi

    void OnMouseDown()
    {
        Debug.Log(gameObject.name + " objesine týklandý!");

        if (gameManager == null) return;

        switch (neYapsin)
        {
            case ClickType.KahveSec:
                gameManager.player.SelectCoffee(kahveVeyaAromaAdi, null);
                break;
            case ClickType.SekerArtir:
                gameManager.player.NextSugar();
                break;
            case ClickType.AromaEkle:
                // Buraya aroma ekleme mantýðýný baðlayabilirsin
                break;
        }
=======
    [Header("Ayarlar")]
    public UnityEvent onMeshClick; // Müfettiþten (Inspector) fonksiyon atayabileceksin
    public Color hoverColor = Color.gray; // Fare üzerine gelince renk deðiþimi
    private Color originalColor;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null) originalColor = meshRenderer.material.color;
    }

    // Dokunmatik veya Fare týklamasý
    void OnMouseDown()
    {
        // Týpký normal butonun OnClick'i gibi çalýþýr
        if (onMeshClick != null)
            onMeshClick.Invoke();

        // Küçük bir basýlma efekti (Opsiyonel)
        transform.localScale *= 0.9f;
    }

    void OnMouseUp()
    {
        transform.localScale /= 0.9f; // Býrakýnca eski boyuta döner
>>>>>>> 0342ab8b4842a10121b1a0e8baca2c70a966e64e
    }
}
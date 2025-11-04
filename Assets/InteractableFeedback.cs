using UnityEngine;

// Bu script, "Interactable" etiketine sahip objelerin
// bakýldýðýnda nasýl tepki vereceðini yönetir.
public class InteractableFeedback : MonoBehaviour
{
    // Baktýðýmýzda hangi renge dönüþsün?
    public Color highlightColor = Color.yellow; // Rengi Unity'den seçebilirsiniz

    private Renderer objRenderer; // Objenin "Mesh Renderer" bileþeni
    private Color originalColor;  // Objenin orijinal rengi

    void Start()
    {
        // 1. Objenin Renderer'ýný bul ve hafýzaya al
        objRenderer = GetComponent<Renderer>();
        if (objRenderer == null)
        {
            Debug.LogError("Bu objede 'Renderer' bulunamadý!", this);
            return;
        }

        // 2. Orijinal rengini kaydet (ki bakmayý býrakýnca geri dönebilelim)
        originalColor = objRenderer.material.color;
    }

    // MouseLook script'i "bana bakýyorsun" dediðinde bu fonksiyonu çaðýracak
    public void OnLookStart()
    {
        objRenderer.material.color = highlightColor;
    }

    // MouseLook script'i "artýk bana bakmýyorsun" dediðinde bu fonksiyonu çaðýracak
    public void OnLookEnd()
    {
        objRenderer.material.color = originalColor;
    }
}
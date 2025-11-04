using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; 

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 2f;

    [Header("Vertical Look (Pitch) Settings")]
    public float verticalLookMin = -45f;
    public float verticalLookMax = 45f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    [Header("Interaction (Raycast) Settings")]
    public float interactionDistance = 5f;
    private InteractableFeedback currentInteractable;

    [Header("Cheating Mechanics")]
    public float cheatTimeRequired = 2.0f;
    private float currentCheatProgress = 0f;
    private bool isCheating = false;

    // --- YENÝ EKLENEN KISIM (UI) ---
    [Header("UI References")]
    public Slider cheatProgressBarUI; // UI'daki Slider'ý buraya baðlayacaðýz
    // --- BÝTTÝ ---

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // GDD Hedefi: Gerilim barý sadece hile yaparken görünmeli.
        // Oyun baþladýðýnda barý gizle.
        if (cheatProgressBarUI != null)
        {
            cheatProgressBarUI.gameObject.SetActive(false); // Barý kapat
            cheatProgressBarUI.value = 0; // Deðerini sýfýrla
        }
    }

    void Update()
    {
        HandleMouseRotation();
        HandleRaycast();
    }

    void HandleMouseRotation()
    {
        if (Mouse.current == null) return;

        float mouseX = Mouse.current.delta.ReadValue().x * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX;

        float mouseY = Mouse.current.delta.ReadValue().y * mouseSensitivity * Time.deltaTime;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, verticalLookMin, verticalLookMax);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }

    // --- BU FONKSÝYON UI ÝÇÝN GÜNCELLENDÝ ---
    void HandleRaycast()
    {
        // 1. GÖZETLEME
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        InteractableFeedback foundInteractable = null;

        if (Physics.Raycast(ray, out hitInfo, interactionDistance))
        {
            foundInteractable = hitInfo.transform.GetComponent<InteractableFeedback>();
        }

        // 2. GÖRSEL GERÝ BÝLDÝRÝM (Highlight)
        if (foundInteractable != null)
        {
            if (foundInteractable != currentInteractable)
            {
                StopLooking();
                currentInteractable = foundInteractable;
                currentInteractable.OnLookStart();
            }
        }
        else
        {
            StopLooking();
        }

        // 3. HÝLE SÜRECÝ (GDD'mizin kalbi)
        if (currentInteractable != null && Keyboard.current.fKey.isPressed)
        {
            // Hile SÜRECÝ BAÞLADI
            if (!isCheating)
            {
                // Hileye *yeni* baþlýyorsak barý göster
                isCheating = true;
                if (cheatProgressBarUI != null)
                    cheatProgressBarUI.gameObject.SetActive(true);
            }

            currentCheatProgress += Time.deltaTime;

            // --- YENÝ UI GÜNCELLEMESÝ ---
            // Bar'ýn deðerini 0 ile 1 arasýnda ayarla
            // (Mevcut süre / Gereken süre)
            if (cheatProgressBarUI != null)
                cheatProgressBarUI.value = currentCheatProgress / cheatTimeRequired;
            // --- BÝTTÝ ---

            if (currentCheatProgress >= cheatTimeRequired)
            {
                // HÝLE BAÞARILI
                Debug.LogWarning("--- HÝLE BAÞARILI! ---");
                ResetCheatState(); // Hile durumunu sýfýrla
            }
        }
        else
        {
            // 'F' tuþu býrakýldý VEYA artýk 'Kart'a bakýlmýyor.
            if (isCheating)
            {
                // HÝLE ÝPTAL EDÝLDÝ
                Debug.Log("HÝLE ÝPTAL EDÝLDÝ! (Risk arttý)");
                ResetCheatState(); // Hile durumunu sýfýrla
            }
        }
    }

    void StopLooking()
    {
        if (currentInteractable != null)
        {
            currentInteractable.OnLookEnd();
            currentInteractable = null;
        }
    }

    // --- YENÝ YARDIMCI FONKSÝYON ---
    // Hile baþarýlý olduðunda veya iptal edildiðinde her þeyi sýfýrlamak için
    void ResetCheatState()
    {
        isCheating = false;
        currentCheatProgress = 0f;
        if (cheatProgressBarUI != null)
        {
            cheatProgressBarUI.gameObject.SetActive(false); // Barý tekrar gizle
            cheatProgressBarUI.value = 0; // Deðerini sýfýrla
        }
    }
}
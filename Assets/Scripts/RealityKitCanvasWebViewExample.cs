using UnityEngine;
using Vuplex.WebView;

/// <summary>
/// Provides a simple example of using 3D WebView's scripting APIs
/// with a CanvasWebViewPrefab.
/// </summary>
public class RealityKitCanvasWebViewExample : MonoBehaviour {

    CanvasWebViewPrefab canvasWebViewPrefab;

    async void Start() {

        // Use a desktop User-Agent to request the desktop versions of websites.
        // https://developer.vuplex.com/webview/Web#SetUserAgent
        // Call this from Awake() to ensure it's called before the webview initializes.
        Web.SetUserAgent(false);

        // Get a reference to the CanvasWebViewPrefab.
        // https://support.vuplex.com/articles/how-to-reference-a-webview
        canvasWebViewPrefab = GameObject.Find("CanvasWebViewPrefab").GetComponent<CanvasWebViewPrefab>();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await canvasWebViewPrefab.WaitUntilInitialized();

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        canvasWebViewPrefab.WebView.UrlChanged += (sender, eventArgs) => {
            Debug.Log("[RealityKitCanvasWebViewExample] URL changed: " + eventArgs.Url);
        };
    }    
}
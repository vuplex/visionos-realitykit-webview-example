# visionOS RealityKit WebView Example

This Unity project demonstrates how to view and interact with web content on Apple Vision Pro using [Vuplex 3D WebView](https://developer.vuplex.com/webview/overview) with Unity's [RealityKit app mode](https://docs.unity3d.com/Packages/com.unity.xr.visionos@2.0/api/UnityEditor.XR.VisionOS.VisionOSSettings.AppMode.html?q=appmode) for visionOS. All you need to do is import [3D WebView for visionOS](https://store.vuplex.com/webview/visionos) into the project and then build the VisionOSRealityKitWebViewExample scene, which demonstrates how to use the [VisionOSWebView.CreateInWindow()](https://developer.vuplex.com/webview/VisionOSWebView#CreateInWindow) API to open a webview in a native visionOS (SwiftUI) window.

![Screenshot of running the project in the visionOS simulator](screenshot.png)

## Steps taken to create this project

1. Created a new project with Unity 6 (6000.0.25) using the 3D URP project template.
2. Opened the Unity Package Manager and did the following:
    - Imported v2.0.4 of the com.unity.polyspatial.visionos package and its dependencies.
    - On the page for the com.unity.polyspatial package, clicked on the "Samples" tab and clicked "Import" button for "Unity PolySpatial Samples".
3. Made a copy of the Manipulation sample scene and named it [VisionOSRealityKitWebViewExample](./Assets/Scenes/VisionOSRealityKitWebViewExample.unity).
4. Added a [VisionOSRealityKitWebViewExample.cs](./Assets/Scripts/VisionOSRealityKitWebViewExample.cs) script that uses the [VisionOSWebView.CreateInWindow()](https://developer.vuplex.com/webview/VisionOSWebView#CreateInWindow) API to open a windowed webview.
5. Removed unneeded objects from the VisionOSRealityKitWebViewExample scene.
6. Updated the following project settings:
    - "XR Plug-in Management": enabled the "Apple visionOS" XR plugin
    - "XR Plug-in Management" -> "Apple visionOS": 
        - Changed the App Mode to "RealityKit"
        - Added values for "Hand Tracking Usage Description" and "World Sensing Usage Description"
        - Enabled "IL2CPP Large Exe Workaround"
    - Player Settings:
        - Disabled "Show Splash Screen"
        - Changed "Color Space" to "Linear"
# visionOS RealityKit WebView Example

This Unity project demonstrates how to view and interact with web content on Apple Vision Pro using [Vuplex 3D WebView](https://developer.vuplex.com/webview/overview) with Unity's [RealityKit app mode](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.0/manual/visionOSPlatformOverview.html#realitykit-with-polyspatial) for visionOS. All you need to do is import [3D WebView for visionOS](https://store.vuplex.com/webview/visionos) into the project and then build one of the following scenes:

- RealityKitWindowedWebViewExample scene: demonstrates using [VisionOSWebView.CreateInWindow()](https://developer.vuplex.com/webview/VisionOSWebView#CreateInWindow) to open a webview in a native visionOS (SwiftUI) window.
- RealityKitCanvasWebViewExample scene: demonstrates using a [CanvasWebViewPrefab](https://developer.vuplex.com/webview/CanvasWebViewPrefab) to display and interact with web content in a Unity UI Canvas.

![Screenshot of running the project in the visionOS simulator](screenshot.png)

## Steps taken to create this project

1. Created a new project with Unity 6 (6000.0.25) using the 3D URP project template.
2. Opened the Unity Package Manager and did the following:
    - Imported v2.3.1 of the com.unity.polyspatial.visionos package and its dependencies.
    - On the page for the com.unity.polyspatial package, clicked on the "Samples" tab and clicked "Import" button for "Unity PolySpatial Samples".
3. To create the RealityKitWindowedWebViewExample scene:
    - Made a copy of PolySpatial's Manipulation sample scene and named it [RealityKitWindowedWebViewExample](./Assets/Scenes/RealityKitWindowedWebViewExample.unity).
    - Added a [RealityKitWindowedWebViewExample.cs](./Assets/Scripts/RealityKitWindowedWebViewExample.cs) script that uses the [VisionOSWebView.CreateInWindow()](https://developer.vuplex.com/webview/VisionOSWebView#CreateInWindow) API to open a windowed webview.
    - Removed unneeded objects from the RealityKitWindowedWebViewExample scene.
4. To create the RealityKitCanvasWebViewExample scene:
    - Made a copy of PolySpatial's GUI sample scene and named it [RealityKitCanvasWebViewExample](./Assets/Scenes/RealityKitWindowedWebViewExample.unity).
    - Added a CanvasWebViewPrefab to the RealityKitCanvasWebViewExample scene's Canvas and set its Initial URL field.
    - Added a [RealityKitCanvasWebViewExample.cs](./Assets/Scripts/RealityKitCanvasWebViewExample.cs) script that demonstrates how to use 3D WebView's scripting APIs.
    - Removed unneeded objects from the RealityKitCanvasWebViewExample scene.    
6. Updated the following project settings:
    - "XR Plug-in Management": enabled the "Apple visionOS" XR plugin
    - "XR Plug-in Management" -> "Apple visionOS": 
        - Changed the App Mode to "RealityKit"
        - Added values for "Hand Tracking Usage Description" and "World Sensing Usage Description"
        - Enabled "IL2CPP Large Exe Workaround"
    - Player Settings:
        - Disabled "Show Splash Screen"
        - Changed "Color Space" to "Linear"
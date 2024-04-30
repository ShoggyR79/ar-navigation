AR Indoor Navigation System
===========================

This Unity project implements an augmented reality (AR) indoor navigation system designed to assist users in navigating within specific indoor environments. It utilizes ARCore for spatial mapping and pathfinding, providing a real-time, interactive navigation experience on Android devices.

Getting Started
---------------

### Prerequisites

*   Unity 2019.4 LTS or newer
*   Android SDK and Build Tools installed through Unity Hub
*   ARCore-supported Android device
*   USB cable for connecting your Android device to your computer

### Running the Project

1.  **Clone the Repository**
    
    *   Clone this repository to your local machine or download the project files.
2.  **Open the Project in Unity**
    
    *   Start Unity Hub and click on 'Add'. Browse to the cloned project directory and add it to your Unity projects list.
    *   Open the project in Unity by clicking on its name in Unity Hub.
3.  **Connect Your Android Device**
    
    *   Connect your Android device to your computer using a USB cable.
    *   Enable USB debugging on your Android device from the developer options.
4.  **Build and Run**
    
    *   With your Android device connected and the project open in Unity, press `Ctrl + B` or go to `File > Build and Run`.
    *   Unity will build the application and automatically deploy it to your connected device.

Usage
-----

*   **Starting Location Limitation**: The application is configured to start from a specific location within the EBI building. You must be at this location for the AR functionalities to operate correctly.
*   **Testing UI and Navigation in Unity**:
    *   If you are not at the EBI or just want to test the UI and navigation features:
        *   Click on the `Play` button in the Unity Editor to start the simulation.
        *   Use the `Toggle Line` button to activate the pathfinding line. This will draw a navigation line based on the selected target from the dropdown menu.
        *   Interact with the dropdown menu to select different target points within the building.
        *   Once a target is selected and the line is toggled, return to the main game view to see the navigation line drawn from your starting point to the selected target.

Limitations
-----------

*   **Starting Location**: The app must be initialized from a predefined starting point within the EBI building to function as intended.
*   **Pathfinding**: The navigation system uses NavMesh for pathfinding, which might result in tight turning angles and may not always provide paths that perfectly center along walkways due to optimization for the shortest route.

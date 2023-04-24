1)  акие плюсы и минусы у того, чтобы сделать GameManager статичным классом?

2) ≈сли нажать на старт левел и после этого прекратить работу игры(нажать на значек плей вверху юнити), то начинают выскакивать ошибки:

MissingReferenceException: The object of type 'UniversalAdditionalCameraData' has been destroyed but you are still trying to access it.
Your script should either check if it is null or you should not destroy the object.
UnityEngine.Component.GetComponent[T] () (at <f7bcd9bfa40c4821acdda68a85850616>:0)
UnityEngine.Rendering.VolumeDebugSettings`1+<get_cameras>d__11[T].MoveNext () (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/VolumeDebugSettings.cs:66)
UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory.CreateCameraSelector (UnityEngine.Rendering.DebugDisplaySettingsVolume data, System.Action`2[T1,T2] refresh) (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettingsVolumes.cs:87)
UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel..ctor (UnityEngine.Rendering.DebugDisplaySettingsVolume data) (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettingsVolumes.cs:363)
UnityEngine.Rendering.DebugDisplaySettingsVolume.CreatePanel () (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettingsVolumes.cs:416)
UnityEngine.Rendering.DebugDisplaySettingsUI+<>c__DisplayClass3_0.<RegisterDebug>b__0 (UnityEngine.Rendering.IDebugDisplaySettingsData data) (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettingsUI.cs:43)
UnityEngine.Rendering.DebugDisplaySettings`1[T].ForEach (System.Action`1[T] onExecute) (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettings.cs:99)
UnityEngine.Rendering.DebugDisplaySettingsUI.RegisterDebug (UnityEngine.Rendering.IDebugDisplaySettings settings) (at Library/PackageCache/com.unity.render-pipelines.core@13.1.8/Runtime/Debugging/DebugDisplaySettingsUI.cs:54)
UnityEngine.Rendering.Universal.UniversalRenderPipeline..ctor (UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset) (at Library/PackageCache/com.unity.render-pipelines.universal@13.1.8/Runtime/UniversalRenderPipeline.cs:203)
UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.CreatePipeline () (at Library/PackageCache/com.unity.render-pipelines.universal@13.1.8/Runtime/Data/UniversalRenderPipelineAsset.cs:384)
UnityEngine.Rendering.RenderPipelineAsset.InternalCreatePipeline () (at <f7bcd9bfa40c4821acdda68a85850616>:0)
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr, Boolean&)

я почитал, такое у многих происходит на unity 2022

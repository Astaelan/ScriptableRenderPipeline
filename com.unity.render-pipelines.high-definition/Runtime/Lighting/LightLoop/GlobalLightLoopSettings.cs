using System;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.HighDefinition
{
    // RenderRenderPipelineSettings represent settings that are immutable at runtime.
    // There is a dedicated RenderRenderPipelineSettings for each platform

    [Serializable]
    public enum CubeReflectionResolution
    {
        CubeReflectionResolution128 = 128,
        CubeReflectionResolution256 = 256,
        CubeReflectionResolution512 = 512,
        CubeReflectionResolution1024 = 1024,
        CubeReflectionResolution2048 = 2048,
        CubeReflectionResolution4096 = 4096
    }

    [Serializable]
    public enum PlanarReflectionAtlasResolution
    {
        PlanarReflectionResolution64 = 64,
        PlanarReflectionResolution128 = 128,
        PlanarReflectionResolution256 = 256,
        PlanarReflectionResolution512 = 512,
        PlanarReflectionResolution1024 = 1024,
        PlanarReflectionResolution2048 = 2048,
        PlanarReflectionResolution4096 = 4096,
        PlanarReflectionResolution8192 = 8192,
        PlanarReflectionResolution16384 = 16384
    }

    [Serializable]
    public enum CookieAtlasResolution
    {
        CookieResolution64 = 64,
        CookieResolution128 = 128,
        CookieResolution256 = 256,
        CookieResolution512 = 512,
        CookieResolution1024 = 1024,
        CookieResolution2048 = 2048,
        CookieResolution4096 = 4096,
        CookieResolution8192 = 8192,
        CookieResolution16384 = 16384
    }

    [Serializable]
    public enum CubeCookieResolution
    {
        CubeCookieResolution64 = 64,
        CubeCookieResolution128 = 128,
        CubeCookieResolution256 = 256,
        CubeCookieResolution512 = 512,
        CubeCookieResolution1024 = 1024,
        CubeCookieResolution2048 = 2048,
        CubeCookieResolution4096 = 4096
    }

    [Serializable]
    public enum AreaCookieResolution
    {
        AreaCookieResolution64 = 64,
        AreaCookieResolution128 = 128,
        AreaCookieResolution256 = 256,
        AreaCookieResolution512 = 512,
        AreaCookieResolution1024 = 1024,
        AreaCookieResolution2048 = 2048,
        AreaCookieResolution4096 = 4096
    }

    [Serializable]
    public struct GlobalLightLoopSettings
    {
        /// <summary>Default GlobalDecalSettings</summary>
        [Obsolete("Since 2019.3, use GlobalLightLoopSettings.NewDefault() instead.")]
        public static readonly GlobalLightLoopSettings @default = default;
        /// <summary>Default GlobalDecalSettings</summary>
        public static GlobalLightLoopSettings NewDefault() => new GlobalLightLoopSettings()
        {
            cookieAtlasSize = CookieAtlasResolution.CookieResolution2048,
            pointCookieSize = CubeCookieResolution.CubeCookieResolution128,
            cubeCookieTexArraySize = 16,

            cookieAreaTextureSize = AreaCookieResolution.AreaCookieResolution128,
            cookieAreaTextureArraySize = 16,

            planarReflectionAtlasSize = PlanarReflectionAtlasResolution.PlanarReflectionResolution1024,
            reflectionProbeCacheSize = 64,
            reflectionCubemapSize = CubeReflectionResolution.CubeReflectionResolution256,

            skyReflectionSize = SkyResolution.SkyResolution256,
            skyLightingOverrideLayerMask = 0,

            maxDirectionalLightsOnScreen = 16,
            maxPunctualLightsOnScreen = 512,
            maxAreaLightsOnScreen = 64,
            maxEnvLightsOnScreen = 64,
            maxDecalsOnScreen = 512,
            maxPlanarReflectionOnScreen = 16,
        };

        [FormerlySerializedAs("cookieSize")]
        public CookieAtlasResolution cookieAtlasSize;
        public CubeCookieResolution pointCookieSize;
        public int cubeCookieTexArraySize;

        public AreaCookieResolution cookieAreaTextureSize;
        public int cookieAreaTextureArraySize;

        [FormerlySerializedAs("planarReflectionTextureSize")]
        public PlanarReflectionAtlasResolution planarReflectionAtlasSize;
        public int reflectionProbeCacheSize;
        public CubeReflectionResolution reflectionCubemapSize;
        public bool reflectionCacheCompressed;
        public bool planarReflectionCacheCompressed;

        public SkyResolution skyReflectionSize;
        public LayerMask skyLightingOverrideLayerMask;
        public bool supportFabricConvolution;

        public int maxDirectionalLightsOnScreen;
        public int maxPunctualLightsOnScreen;
        public int maxAreaLightsOnScreen;
        public int maxEnvLightsOnScreen;
        public int maxDecalsOnScreen;
        public int maxPlanarReflectionOnScreen;
    }
}

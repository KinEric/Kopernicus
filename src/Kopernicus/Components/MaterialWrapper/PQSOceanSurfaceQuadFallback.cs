// Material wrapper generated by shader translator tool

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class PQSOceanSurfaceQuadFallback : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Terrain/PQS/Ocean Surface Quad (Fallback)";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Main Color, default = (1,1,1,1)
            public const String COLOR_KEY = "_Color";
            public Int32 ColorId { get; private set; }

            // Color From Space, default = (1,1,1,1)
            public const String COLOR_FROM_SPACE_KEY = "_ColorFromSpace";
            public Int32 ColorFromSpaceId { get; private set; }

            // Specular Color, default = (1,1,1,1)
            public const String SPEC_COLOR_KEY = "_SpecColor";
            public Int32 SpecColorId { get; private set; }

            // Shininess, default = 0.078125
            public const String SHININESS_KEY = "_Shininess";
            public Int32 ShininessId { get; private set; }

            // Gloss, default = 0.078125
            public const String GLOSS_KEY = "_Gloss";
            public Int32 GlossId { get; private set; }

            // Tex Tiling, default = 1
            public const String TILING_KEY = "_tiling";
            public Int32 TilingId { get; private set; }

            // Tex0, default = "white" { }
            public const String WATER_TEX_KEY = "_WaterTex";
            public Int32 WaterTexId { get; private set; }

            // Tex1, default = "white" { }
            public const String WATER_TEX1_KEY = "_WaterTex1";
            public Int32 WaterTex1Id { get; private set; }

            // FadeStart, default = 1
            public const String FADE_START_KEY = "_fadeStart";
            public Int32 FadeStartId { get; private set; }

            // FadeEnd, default = 1
            public const String FADE_END_KEY = "_fadeEnd";
            public Int32 FadeEndId { get; private set; }

            // PlanetOpacity, default = 1
            public const String PLANET_OPACITY_KEY = "_PlanetOpacity";
            public Int32 PlanetOpacityId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                ColorId = Shader.PropertyToID(COLOR_KEY);
                ColorFromSpaceId = Shader.PropertyToID(COLOR_FROM_SPACE_KEY);
                SpecColorId = Shader.PropertyToID(SPEC_COLOR_KEY);
                ShininessId = Shader.PropertyToID(SHININESS_KEY);
                GlossId = Shader.PropertyToID(GLOSS_KEY);
                TilingId = Shader.PropertyToID(TILING_KEY);
                WaterTexId = Shader.PropertyToID(WATER_TEX_KEY);
                WaterTex1Id = Shader.PropertyToID(WATER_TEX1_KEY);
                FadeStartId = Shader.PropertyToID(FADE_START_KEY);
                FadeEndId = Shader.PropertyToID(FADE_END_KEY);
                PlanetOpacityId = Shader.PropertyToID(PLANET_OPACITY_KEY);
            }
        }

        // Is some random material this material 
        public static Boolean UsesSameShader(Material m)
        {
            return m.shader.name == Properties.Shader.name;
        }

        // Main Color, default = (1,1,1,1)
        public Color Color
        {
            get { return GetColor(Properties.Instance.ColorId); }
            set { SetColor(Properties.Instance.ColorId, value); }
        }

        // Color From Space, default = (1,1,1,1)
        public Color ColorFromSpace
        {
            get { return GetColor(Properties.Instance.ColorFromSpaceId); }
            set { SetColor(Properties.Instance.ColorFromSpaceId, value); }
        }

        // Specular Color, default = (1,1,1,1)
        public Color SpecColor
        {
            get { return GetColor(Properties.Instance.SpecColorId); }
            set { SetColor(Properties.Instance.SpecColorId, value); }
        }

        // Shininess, default = 0.078125
        public Single Shininess
        {
            get { return GetFloat(Properties.Instance.ShininessId); }
            set { SetFloat(Properties.Instance.ShininessId, Mathf.Clamp(value, 0.01f, 1f)); }
        }

        // Gloss, default = 0.078125
        public Single Gloss
        {
            get { return GetFloat(Properties.Instance.GlossId); }
            set { SetFloat(Properties.Instance.GlossId, Mathf.Clamp(value, 0.01f, 1f)); }
        }

        // Tex Tiling, default = 1
        public Single Tiling
        {
            get { return GetFloat(Properties.Instance.TilingId); }
            set { SetFloat(Properties.Instance.TilingId, value); }
        }

        // Tex0, default = "white" { }
        public Texture2D WaterTex
        {
            get { return GetTexture(Properties.Instance.WaterTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.WaterTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 WaterTexScale
        {
            get { return GetTextureScale(Properties.WATER_TEX_KEY); }
            set { SetTextureScale(Properties.WATER_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 WaterTexOffset
        {
            get { return GetTextureOffset(Properties.WATER_TEX_KEY); }
            set { SetTextureOffset(Properties.WATER_TEX_KEY, value); }
        }

        // Tex1, default = "white" { }
        public Texture2D WaterTex1
        {
            get { return GetTexture(Properties.Instance.WaterTex1Id) as Texture2D; }
            set { SetTexture(Properties.Instance.WaterTex1Id, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 WaterTex1Scale
        {
            get { return GetTextureScale(Properties.WATER_TEX1_KEY); }
            set { SetTextureScale(Properties.WATER_TEX1_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 WaterTex1Offset
        {
            get { return GetTextureOffset(Properties.WATER_TEX1_KEY); }
            set { SetTextureOffset(Properties.WATER_TEX1_KEY, value); }
        }

        // FadeStart, default = 1
        public Single FadeStart
        {
            get { return GetFloat(Properties.Instance.FadeStartId); }
            set { SetFloat(Properties.Instance.FadeStartId, value); }
        }

        // FadeEnd, default = 1
        public Single FadeEnd
        {
            get { return GetFloat(Properties.Instance.FadeEndId); }
            set { SetFloat(Properties.Instance.FadeEndId, value); }
        }

        // PlanetOpacity, default = 1
        public Single PlanetOpacity
        {
            get { return GetFloat(Properties.Instance.PlanetOpacityId); }
            set { SetFloat(Properties.Instance.PlanetOpacityId, value); }
        }

        public PQSOceanSurfaceQuadFallback() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public PQSOceanSurfaceQuadFallback(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public PQSOceanSurfaceQuadFallback(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException(
                    "Type Mismatch: Terrain/PQS/Ocean Surface Quad (Fallback) shader required");
            }
        }

    }
}

using UnityEngine;

namespace Smoothie.MonetColors.Runtime
{
    public partial class Colors
    {
        public const int ColorsAmount = 65;
        public static string[] Names { get; } = new string[ColorsAmount] {
            "accent1_0",
            "accent1_10",
            "accent1_50",
            "accent1_100",
            "accent1_200",
            "accent1_300",
            "accent1_400",
            "accent1_500",
            "accent1_600",
            "accent1_700",
            "accent1_800",
            "accent1_900",
            "accent1_1000",
            "accent2_0",
            "accent2_10",
            "accent2_50",
            "accent2_100",
            "accent2_200",
            "accent2_300",
            "accent2_400",
            "accent2_500",
            "accent2_600",
            "accent2_700",
            "accent2_800",
            "accent2_900",
            "accent2_1000",
            "accent3_0",
            "accent3_10",
            "accent3_50",
            "accent3_100",
            "accent3_200",
            "accent3_300",
            "accent3_400",
            "accent3_500",
            "accent3_600",
            "accent3_700",
            "accent3_800",
            "accent3_900",
            "accent3_1000",
            "neutral1_0",
            "neutral1_10",
            "neutral1_50",
            "neutral1_100",
            "neutral1_200",
            "neutral1_300",
            "neutral1_400",
            "neutral1_500",
            "neutral1_600",
            "neutral1_700",
            "neutral1_800",
            "neutral1_900",
            "neutral1_1000",
            "neutral2_0",
            "neutral2_10",
            "neutral2_50",
            "neutral2_100",
            "neutral2_200",
            "neutral2_300",
            "neutral2_400",
            "neutral2_500",
            "neutral2_600",
            "neutral2_700",
            "neutral2_800",
            "neutral2_900",
            "neutral2_1000",
        };

        public static Color GetColor(int index)
        {
            Color color = _fallbackPalette[index];
            if (Application.platform == RuntimePlatform.Android)
            {
                AndroidJavaClass versionClass = new AndroidJavaClass("android.os.Build$VERSION");
                int sdkInt = versionClass.GetStatic<int>("SDK_INT");
                if (sdkInt > 30)
                {
                    AndroidJavaClass colorClass = new AndroidJavaClass("android.R$color");
                    int colorInt = colorClass.GetStatic<int>("system_" + Names[index]);
                    AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    AndroidJavaObject context = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
                    int colorValue = context.Call<AndroidJavaObject>("getResources").Call<int>("getColor", colorInt);
                    colorClass = new AndroidJavaClass("android.graphics.Color");
                    AndroidJavaObject colorObject = colorClass.CallStatic<AndroidJavaObject>("valueOf", colorValue);
                    float red = colorObject.Call <float>("red");
                    float green = colorObject.Call <float>("green");
                    float blue = colorObject.Call <float>("blue");
                    color = new Color(red, green, blue);
                }
            }
            return color;
        }

    }
}

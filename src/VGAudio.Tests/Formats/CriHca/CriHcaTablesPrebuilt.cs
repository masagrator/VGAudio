﻿namespace VGAudio.Tests.Formats.CriHca
{
    public static class CriHcaTablesPrebuilt
    {
        public static float[] DequantizerScalingTable { get; } =
        {
            1.58838333e-7f, 2.11641364e-7f, 2.81997842e-7f, 3.75743127e-7f, 5.00652334e-7f, 6.67085487e-7f, 8.88846444e-7f, 1.18432786e-6f,
            1.57803709e-6f, 2.10262783e-6f, 2.80160975e-6f, 3.73295620e-6f, 4.97391238e-6f, 6.62740285e-6f, 8.83056691e-6f, 1.17661348e-5f,
            1.56775804e-5f, 2.08893198e-5f, 2.78336083e-5f, 3.70864072e-5f, 4.94151354e-5f, 6.58423305e-5f, 8.77304701e-5f, 1.16894931e-4f,
            1.55754606e-4f, 2.07532517e-4f, 2.76523089e-4f, 3.68448353e-4f, 4.90932551e-4f, 6.54134550e-4f, 8.71590164e-4f, 1.16133504e-3f,
            1.54740061e-3f, 2.06180708e-3f, 2.74721882e-3f, 3.66048375e-3f, 4.87734750e-3f, 6.49873680e-3f, 8.65912810e-3f, 1.15377046e-2f,
            1.53732123e-2f, 2.04837695e-2f, 2.72932407e-2f, 3.63664031e-2f, 4.84557785e-2f, 6.45640567e-2f, 8.60272497e-2f, 1.14625506e-1f,
            1.52730748e-1f, 2.03503430e-1f, 2.71154583e-1f, 3.61295193e-1f, 4.81401473e-1f, 6.41435027e-1f, 8.54668856e-1f, 1.13878858e+0f,
            1.51735902e+0f, 2.02177858e+0f, 2.69388366e+0f, 3.58941817e+0f, 4.78265762e+0f, 6.37256861e+0f, 8.49101734e+0f, 1.13137083e+1f
        };

        public static float[] DequantizerNormalizeTable { get; } =
        {
            0.0000000e+0f, 6.6666666e-1f, 4.0000000e-1f, 2.8571430e-1f, 2.2222222e-1f, 1.8181818e-1f, 1.5384616e-1f, 1.3333334e-1f,
            6.4516127e-2f, 3.1746034e-2f, 1.5748031e-2f, 7.8431377e-3f, 3.9138943e-3f, 1.9550342e-3f, 9.7703957e-4f, 4.8840052e-4f
        };

        public static float[] IntensityRatioTable { get; } =
        {
            2.00000000e+0f, 1.85714281e+0f, 1.71428573e+0f, 1.57142854e+0f, 1.42857146e+0f, 1.28571427e+0f, 1.14285719e+0f, 1.00000000e+0f,
            8.57142866e-1f, 7.14285731e-1f, 5.71428597e-1f, 4.28571433e-1f, 2.85714298e-1f, 1.42857149e-1f, 0.00000000e+0f, 0.00000000e+0f
        };

        public static float[] ScaleConversionTable { get; } =
        {
            0.00000000e+0f, 0.00000000e+0f, 1.87066309e-8f, 2.49253240e-8f, 3.32113146e-8f, 4.42518342e-8f, 5.89625841e-8f, 7.85636658e-8f,
            1.04680787e-7f, 1.39480093e-7f, 1.85847810e-7f, 2.47629657e-7f, 3.29949842e-7f, 4.39635897e-7f, 5.85785187e-7f, 7.80519201e-7f,
            1.03998923e-6f, 1.38571545e-6f, 1.84637236e-6f, 2.46016680e-6f, 3.27800626e-6f, 4.36772189e-6f, 5.81969516e-6f, 7.75435092e-6f,
            1.03321499e-5f, 1.37668931e-5f, 1.83434568e-5f, 2.44414186e-5f, 3.25665424e-5f, 4.33927198e-5f, 5.78178697e-5f, 7.70384140e-5f,
            1.02648490e-4f, 1.36772185e-4f, 1.82239717e-4f, 2.42822120e-4f, 3.23544111e-4f, 4.31100692e-4f, 5.74412581e-4f, 7.65366014e-4f,
            1.01979857e-3f, 1.35881291e-3f, 1.81052648e-3f, 2.41240440e-3f, 3.21436627e-3f, 4.28292621e-3f, 5.70671028e-3f, 7.60380644e-3f,
            1.01315593e-2f, 1.34996194e-2f, 1.79873314e-2f, 2.39669066e-2f, 3.19342874e-2f, 4.25502807e-2f, 5.66953793e-2f, 7.55427703e-2f,
            1.00655645e-1f, 1.34116858e-1f, 1.78701669e-1f, 2.38107920e-1f, 3.17262739e-1f, 4.22731191e-1f, 5.63260794e-1f, 7.50507057e-1f,

            1.00000000e+0f, 1.33243251e+0f, 1.77537644e+0f, 2.36556935e+0f, 3.15196180e+0f, 4.19977617e+0f, 5.59591866e+0f, 7.45618439e+0f,
            9.93486214e+0f, 1.32375345e+1f, 1.76381207e+1f, 2.35016060e+1f, 3.13143063e+1f, 4.17242012e+1f, 5.55946846e+1f, 7.40761642e+1f,
            9.87014923e+1f, 1.31513077e+2f, 1.75232315e+2f, 2.33485229e+2f, 3.11103333e+2f, 4.14524200e+2f, 5.52325500e+2f, 7.35936523e+2f,
            9.80585754e+2f, 1.30656433e+3f, 1.74090894e+3f, 2.31964380e+3f, 3.09076880e+3f, 4.11824072e+3f, 5.48727832e+3f, 7.31142822e+3f,
            9.74198438e+3f, 1.29805371e+4f, 1.72956914e+4f, 2.30453418e+4f, 3.07063633e+4f, 4.09141563e+4f, 5.45153555e+4f, 7.26380313e+4f,
            9.67852813e+4f, 1.28959852e+5f, 1.71830313e+5f, 2.28952297e+5f, 3.05063500e+5f, 4.06476531e+5f, 5.41602563e+5f, 7.21648875e+5f,
            9.61548438e+5f, 1.28119838e+6f, 1.70711050e+6f, 2.27460950e+6f, 3.03076375e+6f, 4.03828825e+6f, 5.38074700e+6f, 7.16948200e+6f,
            9.55285100e+6f, 1.27285300e+7f, 1.69599080e+7f, 2.25979340e+7f, 3.01102220e+7f, 4.01198400e+7f, 5.34569800e+7f, 0.00000000e+0f
        };

        public static int[] ResolutionLevels { get; } =
        {
            1, 3, 5, 7, 9, 11, 13, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095
        };
    }
}

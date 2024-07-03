using System;
using System.Runtime.InteropServices;
using System.Threading;

public class Program
{
    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int X, int Y);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    private const uint WM_CHAR = 0x0102;

    public static void Main()
    {
        IntPtr hWnd = FindWindow(null, "SuperMU || Player: Imperadora || Level: 336 || SuperCoin: 538 || Super Coin(P): 0 || EventPoint: 230"); // Substitua "Nome da Janela Aqui" pelo nome da janela desejada
        if (hWnd != IntPtr.Zero)
        {
            string texto = "texto aleatorio";

            foreach (char c in texto)
            {
                PostCharacter(hWnd, c);
                Thread.Sleep(1000); // Aguarde um breve intervalo entre cada caractere
            }
        }
        else
        {
            Console.WriteLine("Janela não encontrada.");
        }
    }

    private static void PostCharacter(IntPtr hWnd, char c)
    {
        PostMessage(hWnd, WM_CHAR, (IntPtr)c, IntPtr.Zero);
    }
}
 
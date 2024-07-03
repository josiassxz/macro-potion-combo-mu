using System;
using System.Runtime.InteropServices;
using System.Threading;

public class Program
{
   const int WM_KEYDOWN = 0x0100;
const int WM_CHAR = 0x0102;

[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

[DllImport("user32.dll", SetLastError = true)]
static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

[DllImport("user32.dll", SetLastError = true)]
static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


    static void Main(string[] args)
{
    IntPtr gameWindowHandle = FindWindowByProcessId(4908); // Substitua 4908 pelo PID do seu jogo

    if (gameWindowHandle != IntPtr.Zero)
    {
        // Enviar mensagem de tecla pressionada
        SendMessage(gameWindowHandle, WM_KEYDOWN, (IntPtr)Keys.Return, IntPtr.Zero);

        // Enviar mensagem de caractere digitado
        SendMessage(gameWindowHandle, WM_CHAR, (IntPtr)Keys.Return, IntPtr.Zero);
    }
    else
    {
        Console.WriteLine("Janela do jogo não encontrada.");
    }
}

  



 
}

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
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;

    private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
    private const uint KEYEVENTF_KEYUP = 0x0002;

    public static void Main()
    {
        while (true)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            int minute = now.Minute;

            // Verifica se a hora e o minuto correspondem aos horários específicos
            if ((hour == 0 && minute == 27) ||
                (hour == 2 && minute == 27) ||
                (hour == 4 && minute == 27) ||
                (hour == 6 && minute == 27) ||
                (hour == 8 && minute == 27) ||
                (hour == 10 && minute == 27) ||
                (hour == 12 && minute == 27) ||
                (hour == 14 && minute == 27) ||
                (hour == 16 && minute == 27) ||
                (hour == 18 && minute == 27) ||
                (hour == 20 && minute == 27) ||
                (hour == 22 && minute == 27))
            {
                ExecuteCode();
            }

            // Verifica a cada 20 segundos
            Thread.Sleep(20000);
        }
    }

    private static void ExecuteCode()
    {
        // Ativa a janela SuperMU se não estiver ativa
        IntPtr hWnd = FindWindow("SuperMU", null);
        if (hWnd != IntPtr.Zero)
        {
            SetForegroundWindow(hWnd);
        }

        Thread.Sleep(3000);

        // Digita enter
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(200); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(2000);

        // Digita "/"
        keybd_event(0xBF, 0, 0, (UIntPtr)0); // Código da tecla "/"
        Thread.Sleep(200); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0xBF, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "/"

        Thread.Sleep(2000);

        // Digita "c"
        keybd_event(0x43, 0, 0, (UIntPtr)0); // Código da tecla "c"
        Thread.Sleep(200); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x43, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "c"

        Thread.Sleep(2000);

        // Código da tecla "m"
        keybd_event(0x4D, 0, 0, (UIntPtr)0);
        Thread.Sleep(200); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x4D, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "m"

        Thread.Sleep(2000);

        // Digita enter
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(200); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(5000);

        // Move até o NPC
        SetCursorPos(810, 334); // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica no NPC
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(5000);

        // Move para a posição ds 6
        SetCursorPos(1410, 880); // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição ds 6
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(5000);

        // Move até a posição do spot
        SetCursorPos(1487, 762); // ALTERAR AQUI
        Thread.Sleep(1000);

        Thread.Sleep(3000);

        // Pressiona a tecla Home
        keybd_event(0x24, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x24, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(25 * 60 * 1000); // Espera 30 minutos ds acabar

        // Ativa a janela SuperMU se não estiver ativa
        if (hWnd != IntPtr.Zero)
        {
            SetForegroundWindow(hWnd);
        }

        Thread.Sleep(3000);

        // Pressiona Enter para sair do ds
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(5000);

        PressKeySequenceSpot("/vulcanusvip12");

        Thread.Sleep(3000);

        // Pressiona a tecla Home
        keybd_event(0x24, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x24, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }

    private static void ExecuteCodeBC()
    {
        Thread.Sleep(3000);

        PressKeySequenceSpot("/igreja");

        Thread.Sleep(2000);

        // Move até o NPC
        SetCursorPos(1080, 330); // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica no NPC
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(2000);

        // Move para a posição do spot bc
        SetCursorPos(1066, 402);
        Thread.Sleep(1000);

        // Clica para entra bc
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(2 * 60 * 1000); // Espera 2 minutos bc iniciar

        // Move para a posição do spot bc
        SetCursorPos(1230, 380);
        Thread.Sleep(1000);

        // Clica na posição do spot 1
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(3000);

        // Clica na posição do spot 2
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(3000);

        // Clica na posição do spot 3
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(3000);

        // Clica na posição do spot 4
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        Thread.Sleep(3000);

        // Pressiona a tecla Home
        keybd_event(0x24, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100);
        keybd_event(0x24, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(16 * 60 * 1000); // Espera 16 minutos bc acabar

        // Pressiona Enter para sair do bc
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(3000);

        PressKeySequenceSpot("/vulcanusvip12");

        Thread.Sleep(3000);

        // Pressiona a tecla Home
        keybd_event(0x24, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x24, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }

    private static void PressKeySequenceSpot(string text)
    {
        Thread.Sleep(5000);

        // Pressiona Enter
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(2000);

        foreach (char c in text)
        {
            byte vk = VkKeyScanSpot(c);
            keybd_event(vk, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(vk, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
        }

        Thread.Sleep(2000);

        // Pressiona Enter
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }

    private static byte VkKeyScanSpot(char ch)
    {
        byte vk = 0;
        switch (ch)
        {
            case '/': vk = 0xBF; break;
            case 'v': vk = 0x56; break;
            case 'u': vk = 0x55; break;
            case 'l': vk = 0x4C; break;
            case 'c': vk = 0x43; break;
            case 'a': vk = 0x41; break;
            case 'n': vk = 0x4E; break;
            case 's': vk = 0x53; break;
            case 'i': vk = 0x49; break;
            case 'p': vk = 0x50; break;
            case 'g': vk = 0x47; break;
            case 'r': vk = 0x52; break;
            case 'e': vk = 0x45; break;
            case 'j': vk = 0x4A; break;
            case '1': vk = 0x31; break;
            case '2': vk = 0x32; break;
            default: break;
        }
        return vk;
    }
}

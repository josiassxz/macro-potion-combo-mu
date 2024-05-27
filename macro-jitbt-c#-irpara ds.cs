﻿using System;
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
            int segundos = now.Second;

            // Verifica se a hora e o minuto correspondem aos horários específicos
            if ((hour == 0 && minute == 25) ||
                (hour == 2 && minute == 25) ||
                (hour == 4 && minute == 25) ||
                (hour == 6 && minute == 25) ||
                (hour == 8 && minute == 25) ||
                (hour == 10 && minute == 25) ||
                (hour == 12 && minute == 25) ||
                (hour == 14 && minute == 25) ||
                (hour == 16 && minute == 25) ||
                (hour == 18 && minute == 25) ||
                (hour == 22 && minute == 25) ||
                (hour == 20 && minute == 25))
            {
                
                ExecuteCode();
            }

            // Verifica a cada minuto
            Thread.Sleep(20000);
        }
    }

    private static void ExecuteCode()
    {

          Thread.Sleep(3000);

        //digita enter
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);


        // Digita "/"
        keybd_event(0xBF, 0, 0, (UIntPtr)0); // Código da tecla "/"
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0xBF, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "/"

        // Digita "c"
        keybd_event(0x43, 0, 0, (UIntPtr)0); // Código da tecla "c"
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x43, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "c"
        keybd_event(0x4D, 0, 0, (UIntPtr)0); 

        // Código da tecla "m"
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x4D, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "m"

        //digita enter
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(5000);

        //digita enter
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(100); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
      

        // Digita "/"
        keybd_event(0xBF, 0, 0, (UIntPtr)0); // Código da tecla "/"
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0xBF, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "/"

        // Digita "c"
        keybd_event(0x43, 0, 0, (UIntPtr)0); // Código da tecla "c"
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x43, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "c"
        
        
        // Código da tecla "m"
        keybd_event(0x4D, 0, 0, (UIntPtr)0); 
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x4D, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Solta a tecla "m"

        //digita enter
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);


        Thread.Sleep(5000);



        Thread.Sleep(8000);

        // Move até o NPC
        SetCursorPos(739, 209); // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica no NPC
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(15000);

        // Move para a posição ds 6
        SetCursorPos(1421, 808); // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição ds 6
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(10000);

        // Move até a posição do spot
        SetCursorPos(1174, 389);  // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição do spot
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(1000);

        // Move até a posição do spot 2
        SetCursorPos(1174, 389);  // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição do spot 2
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(5000);

        // move para o helper
        SetCursorPos(651, 139); // ALTERAR AQUI
        Thread.Sleep(3000);

        // Clica no helper
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

     
        Thread.Sleep(28 * 60 * 1000); // Espera 30 minutos ds acabar

        // Pressiona Enter para sair do ds
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);


        Thread.Sleep(5000);

        //digita enter para digitar
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(3000);

            PressKeySequenceSpot("/kanturuvip23");

        Thread.Sleep(3000);


        //digita enter para digitar
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);    

         Thread.Sleep(3000);

          //digita enter para digitar
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);

        Thread.Sleep(3000);

            PressKeySequenceSpot("/kanturuvip23");

        Thread.Sleep(3000);


        //digita enter para digitar
         keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50); // Pequeno delay para garantir que a tecla é pressionada
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);    

        Thread.Sleep(3000);

        // Move até a posição do spot
        SetCursorPos(581, 844);  // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição do spot
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(1000);

        // Move até a posição do spot 2
        SetCursorPos(581, 844);   // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição do spot 2
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(5000);    

        // Move até a posição do spot 3
        SetCursorPos(1184, 911);  // ALTERAR AQUI
        Thread.Sleep(1000);

        // Clica na posição do spot 3
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        Thread.Sleep(5000);   


        // move para o helper
        SetCursorPos(651, 139); // ALTERAR AQUI
        Thread.Sleep(3000);

        // Clica no helper
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(100);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

 
    }

    private static void PressKeySequenceSpot(string text)
    {
        foreach (char c in text)
        {
            byte vk = VkKeyScanSpot(c);
            keybd_event(vk, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(vk, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
        }

        // Pressiona Enter
        keybd_event(0x0D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        Thread.Sleep(50);
        keybd_event(0x0D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }



    private static byte VkKeyScanSpot(char ch)
    {
        byte vk = 0;
        switch (ch)
        {
            case '/': vk = 0xBF; break;
            case 'k': vk = 0x4B; break;
            case 'a': vk = 0x41; break;
            case 'n': vk = 0x4E; break;
            case 't': vk = 0x54; break;
            case 'u': vk = 0x55; break;
            case 'r': vk = 0x52; break;
            case 'v': vk = 0x56; break;
            case 'i': vk = 0x49; break;
            case 'p': vk = 0x50; break;
            case '2': vk = 0x32; break;
            case '3': vk = 0x33; break;
            default: break;
        }
        return vk;
    }
}

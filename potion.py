import tkinter as tk
import pydirectinput
import time
import threading
from pynput import keyboard

# Variável de controle para iniciar/parar o loop
running = False

def press_keys():
    global running
    while running:
        pydirectinput.press('q')
        time.sleep(0.001)
        pydirectinput.press('w')
        time.sleep(0.001)
        pydirectinput.press('e')
        time.sleep(0.001)

def start_pressing():
    global running
    if not running:
        running = True
        threading.Thread(target=press_keys).start()

def stop_pressing():
    global running
    running = False

def on_press(key):
    try:
        if key == keyboard.Key.f5:
            start_pressing()
        elif key == keyboard.Key.f6:
            stop_pressing()
    except AttributeError:
        pass

# Listener do teclado
keyboard_listener = keyboard.Listener(on_press=on_press)
keyboard_listener.start()

# Interface gráfica usando tkinter
def create_gui():
    root = tk.Tk()
    root.title("Controlador de Teclas")

    start_button = tk.Button(root, text="Start (F5)", command=start_pressing)
    start_button.pack(pady=10)

    stop_button = tk.Button(root, text="Stop (F6)", command=stop_pressing)
    stop_button.pack(pady=10)

    root.mainloop()

if __name__ == "__main__":
    create_gui()

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
        time.sleep(0.15)
        pydirectinput.press('w')
        time.sleep(0.15)
        pydirectinput.press('e')
        time.sleep(0.15)

def on_press(key):
    global running
    try:
        if key == keyboard.Key.f5:
            if not running:
                running = True
                threading.Thread(target=press_keys).start()
        elif key == keyboard.Key.f6:
            running = False
    except AttributeError:
        pass

# Configura o listener do teclado
listener = keyboard.Listener(on_press=on_press)
listener.start()
listener.join()

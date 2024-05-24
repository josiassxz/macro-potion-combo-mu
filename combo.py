import tkinter as tk
import pydirectinput
import time
import threading
from pynput import keyboard
import os

# Variável de controle para iniciar/parar o loop
running = False

# Intervalos iniciais de tempo em milissegundos
intervals = {'1': 100, '2': 100, '3': 100}
intervals_file = 'intervals.txt'

def load_intervals():
    if os.path.exists(intervals_file):
        with open(intervals_file, 'r') as file:
            for line in file:
                key, interval = line.strip().split(',')
                intervals[key] = int(interval)
    else:
        save_intervals()  # Save default intervals if the file does not exist

def save_intervals():
    with open(intervals_file, 'w') as file:
        for key, interval in intervals.items():
            file.write(f"{key},{interval}\n")

def press_keys():
    global running
    while running:
        pydirectinput.press('1')
        time.sleep(intervals['1'] / 1000.0)
        pydirectinput.press('2')
        time.sleep(intervals['2'] / 1000.0)
        pydirectinput.press('3')
        time.sleep(intervals['3'] / 1000.0)

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

# Funções para ajustar o intervalo
def increase_interval(key):
    global intervals
    intervals[key] += 1
    update_labels()
    save_intervals()

def decrease_interval(key):
    global intervals
    if intervals[key] > 1:
        intervals[key] -= 1
        update_labels()
        save_intervals()

def update_labels():
    label_1.config(text=f"Intervalo para '1': {intervals['1']} ms")
    label_2.config(text=f"Intervalo para '2': {intervals['2']} ms")
    label_3.config(text=f"Intervalo para '3': {intervals['3']} ms")

# Interface gráfica usando tkinter
def create_gui():
    global label_1, label_2, label_3
    load_intervals()
    
    root = tk.Tk()
    root.title("Controlador de Teclas")

    start_button = tk.Button(root, text="Start (F5)", command=start_pressing)
    start_button.grid(row=0, column=0, columnspan=2, pady=10)

    stop_button = tk.Button(root, text="Stop (F6)", command=stop_pressing)
    stop_button.grid(row=1, column=0, columnspan=2, pady=10)

    label_1 = tk.Label(root, text=f"Intervalo para '1': {intervals['1']} ms")
    label_1.grid(row=2, column=0, columnspan=2)

    up_button_1 = tk.Button(root, text="▲", command=lambda: increase_interval('1'))
    up_button_1.grid(row=3, column=0, padx=5, pady=5)

    down_button_1 = tk.Button(root, text="▼", command=lambda: decrease_interval('1'))
    down_button_1.grid(row=3, column=1, padx=5, pady=5)

    label_2 = tk.Label(root, text=f"Intervalo para '2': {intervals['2']} ms")
    label_2.grid(row=4, column=0, columnspan=2)

    up_button_2 = tk.Button(root, text="▲", command=lambda: increase_interval('2'))
    up_button_2.grid(row=5, column=0, padx=5, pady=5)

    down_button_2 = tk.Button(root, text="▼", command=lambda: decrease_interval('2'))
    down_button_2.grid(row=5, column=1, padx=5, pady=5)

    label_3 = tk.Label(root, text=f"Intervalo para '3': {intervals['3']} ms")
    label_3.grid(row=6, column=0, columnspan=2)

    up_button_3 = tk.Button(root, text="▲", command=lambda: increase_interval('3'))
    up_button_3.grid(row=7, column=0, padx=5, pady=5)

    down_button_3 = tk.Button(root, text="▼", command=lambda: decrease_interval('3'))
    down_button_3.grid(row=7, column=1, padx=5, pady=5)

    root.mainloop()

if __name__ == "__main__":
    create_gui()

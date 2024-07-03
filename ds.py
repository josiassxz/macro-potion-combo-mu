import ctypes
import time

# Carrega a biblioteca user32.dll
user32 = ctypes.windll.user32

# Define as constantes para os eventos do mouse
MOUSEEVENTF_MOVE = 0x0001
MOUSEEVENTF_ABSOLUTE = 0x8000
MOUSEEVENTF_LEFTDOWN = 0x0002
MOUSEEVENTF_LEFTUP = 0x0004

# Função para mover o cursor do mouse
def set_mouse_position(x, y):
    user32.SetCursorPos(x, y)

# Função para simular um clique do mouse
def mouse_click():
    user32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    user32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

time.sleep(3)
# Mover o mouse para as coordenadas (691, 256)
set_mouse_position(691, 256)
time.sleep(0.5)  # Pequeno delay para garantir que o movimento foi completado

# Dormir por 3 segundos
time.sleep(3)

# Tentar um clique
mouse_click()

print("Mouse moved and clicked using user32.dll.")

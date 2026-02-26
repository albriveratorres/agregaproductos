import requests
import json

API = "http://localhost:5207/api/productos"

respuesta = requests.get(API)

productos = respuesta.json()

with open("productos.json", "w") as archivo:
    json.dump(productos, archivo, indent=4)

print("Productos exportados a productos.json")
import csv
import requests

API = "http://localhost:5207/api/productos"

with open("productos.csv") as archivo:

    lector = csv.DictReader(archivo)

    for fila in lector:

        producto = {
            "nombre": fila["Nombre"],
            "precio": float(fila["Precio"])
        }

        r = requests.post(API, json=producto)

        print("Enviado:", producto, "Status:", r.status_code)
# Proyecto de aplicacion VB 

Esta aplicacion permite tomar el codigo postal
y apartir de ese dato 
> Encontrar la ciudad, estado y demas datos

## Setup del Proyecto

1. Clonar el proyecto 

```pwsh
git clone https://github.com/Atticus64/codigoPostalApp.git
```

2. Abrir el proyecto con Visual Studio 

Se puede hacer de 2 maneras 

* Dando db click al archivo `codigoPostalApp.sln`  
* Abriendo el proyecto desde Visual Studio como proyecto o solución

3. Agregar cambios al diseño y código

* Agregar cambios

```bash
git add . # si se quiere agregar todos los cambios
git add filename 
# si se quiere agregar los cambios de un solo archivo
git add folder/
# si se quiere agregar los cambios de una carpeta
```

* Guardar los cambios en git

```bash
# git commit -m "Mensaje de los cambios"
# ejemplo
git commit -m "feat: Agregar boton de salir"
# Recomiendo usar 2 partes del Mensaje
# tipo de aporte: mensaje del cambio
# feat: -> feature
# fix: -> Arreglar algo
# docs: -> Agregar documentacion
```

* Subir los cambios

> [!NOTE]
> Debe estar configurado el correo y usuario de git en el proyecto o equipo

* Configuración

```bash
git config user.email "tuemail@gmail.com"
git config user.name "tuNombre"
```

* Subir al repositorio remoto

```bash
git push 
```


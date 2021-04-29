### Primero
Instálate `.NET 5.0` en https://dotnet.microsoft.com/download

### Compilar y ejecutar
En cualquier consola:
- Compilar, solo la primera vez (o cada vez que se modifique el código)
```
cd Bustroker.ReadImgProps.ConsoleUI
dotnet build
```

- Ejecutar
**Antes de ejecutar, hay que guardar las imágenes en una carpeta `img` creada en `Bustroker.ReadImgProps.ConsoleUI`, que son las que se van a leer**
```
dotnet run
```

Se creará un file `output.csv` con toda la info. Cada vez que haces `dotnet run` se elimina el archivo `output.csv` y se vuelve a generar.
El `output.csv` tiene una línea por cada imagen que se encuentre en la carpeta `img`, con las propiedades separadas por `,`.
 
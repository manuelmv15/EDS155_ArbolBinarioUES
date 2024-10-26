namespace portafolio6_arbolBinarioUES
{
    class Program
    {
        static void Main(string[] args)
        {
            arbolBinario arbolUES = new arbolBinario();

            // Nivel 1 (Raíz)
            arbolUES.Insertar("UES", 1);

            // Nivel 2
            arbolUES.Insertar("Decano", 1, "UES");
            arbolUES.Insertar("Vice Decano", 2, "UES");

            // Nivel 3
            arbolUES.Insertar("Administrativos", 1, "Decano");
            arbolUES.Insertar("Académica", 2, "Decano");
            arbolUES.Insertar("Departamentos", 1, "Vice Decano");
            arbolUES.Insertar("Postgrado", 2, "Vice Decano");

            // Nivel 4
            arbolUES.Insertar("Biblioteca", 1, "Administrativos");
            arbolUES.Insertar("UES", 2, "Administrativos");
            arbolUES.Insertar("Nuevo Ingreso", 1, "Académica");
            arbolUES.Insertar("Procesos Académicos", 2, "Académica");
            arbolUES.Insertar("Docentes", 1, "Departamentos");
            arbolUES.Insertar("Técnicos", 2, "Departamentos");
            arbolUES.Insertar("Maestría", 1, "Postgrado");
            arbolUES.Insertar("Doctorado", 2, "Postgrado");

            // Mostrar el árbol
            arbolUES.Mostrar(arbolUES.Raiz);

        }

    }

}
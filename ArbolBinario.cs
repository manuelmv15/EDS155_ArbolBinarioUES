namespace portafolio6_arbolBinarioUES
{
    class Nodo
    {
        public string Valor;
        public Nodo Izquierdo, Derecho;

        public Nodo(string valor)
        {
            this.Valor = valor;
            Izquierdo = Derecho = null;
        }
    }

    class arbolBinario
    {
        public Nodo Raiz;

        public arbolBinario()
        {
            Raiz = null;
        }

        // Método para insertar un nodo en el árbol en función del lado
        public void Insertar(string valor, int lado)
        {
            
            if (Raiz == null)
            {
                Raiz = new Nodo(valor);
            }
            else
            {
             
                InsertarEnNodo(Raiz, valor, lado);
            }
        }

        public void Insertar(string valor, int lado, string referencia)
        {
            
            Nodo nodoReferencia = BuscarNodo(Raiz, referencia);

            if (nodoReferencia != null)
            {
               
                InsertarEnNodo(nodoReferencia, valor, lado);
            }
            else
            {
                Console.WriteLine($"Nodo con valor '{referencia}' no encontrado.");
            }
        }

   
        private void InsertarEnNodo(Nodo nodo, string valor, int lado)
        {
            if (lado == 1) // Lado izquierdo
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new Nodo(valor);
                }
                else
                {
                    Console.WriteLine("El nodo izquierdo ya está ocupado.");
                }
            }
            else if (lado == 2) // Lado derecho
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new Nodo(valor);
                }
                else
                {
                    Console.WriteLine("El nodo derecho ya está ocupado.");
                }
            }
        }

        private Nodo BuscarNodo(Nodo nodo, string valor)
        {
            if (nodo == null) return null;
            if (nodo.Valor == valor) return nodo;

            // Busca en el subárbol izquierdo y derecho
            Nodo encontrado = BuscarNodo(nodo.Izquierdo, valor);
            if (encontrado == null)
            {
                encontrado = BuscarNodo(nodo.Derecho, valor);
            }
            return encontrado;
        }

        // Método para mostrar el árbol en consola
        public void Mostrar(Nodo nodo, string identacion = "", bool esDerecho = true)
        {
            if (nodo == null)
            {
                return;
            }

            if (esDerecho)
            {
                Mostrar(nodo.Derecho, identacion + "     ", false);
            }
            else
            {
                Mostrar(nodo.Derecho, identacion + "|    ", false);
            }

            Console.WriteLine(identacion + (esDerecho ? "└── " : "┌── ") + nodo.Valor);

            if (esDerecho)
            {
                Mostrar(nodo.Izquierdo, identacion + "     ", true);
            }
            else
            {
                Mostrar(nodo.Izquierdo, identacion + "|    ", true);
            }
        }
    }
}

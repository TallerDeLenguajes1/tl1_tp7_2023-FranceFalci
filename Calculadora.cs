// Dentro de este proyecto, crear un nuevo archivo llamado Calculadora.cs y defina un
// espacio de nombres al comienzo del archivo (ej. namespace EspacioCalculadora;
// en la linea 1 del archivo) . Cree la clase Calculadora que permita encadenar
// operaciones sobre un mismo resultado guardado en un atributo llamado dato,
// utilizando los siguientes métodos.
// ● void Sumar(double termino)
// ● void Restar(double termino)
// ● void Multiplicar(double termino)
// ● void Dividir(double termino)
// ● void Limpiar()

namespace EspacioCaclculadora;

    public class Calculadora{
    private double dato = 0;

    public int Dato { get => dato; set => dato = value; }
    public int Resultado { get => dato;}


        void Sumar(double termino){
            dato+= termino;
    
        }
        void Restar(double termino){
            dato-= termino;
        }
        void Multiplicar(double termino){
            dato*= termino;

        }   
        void Dividir(double termino){
            if(termino != 0) dato = dato/termino;
        }
        void Limpiar(){
            dato = 0;
        }
    }

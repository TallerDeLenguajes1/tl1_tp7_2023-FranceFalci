

namespace EspacioCaclculadora;

    public class Calculadora{
    private double dato=0;



    public double Dato { get => dato; set => dato = value; }
    public double Resultado { get => dato;}


    public void Sumar(double termino){
            dato+= termino;
    
        }
    public   void Restar(double termino){
            dato-= termino;
        }
    public void Multiplicar(double termino){
            dato*= termino;

        }   
    public  void Dividir(double termino){
            if(termino != 0) dato = dato/termino;
        }
    public void Limpiar(){
            dato = 0;
        }
    }

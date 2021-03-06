using System;

namespace Granja
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1= new Producto();
            producto1.Nombre = "Frijol";
            producto1.ValorUnit = 2000;
            producto1.UnixKm = 10;

            Producto producto2 = new Producto();
            producto2.Nombre = "Maiz";
            producto2.ValorUnit = 1000;
            producto2.UnixKm = 15;

            Producto producto3 = new Producto();
            producto3.Nombre = "Papa";
            producto3.ValorUnit = 3000;
            producto3.UnixKm = 20;

            Campesino usuario1 = new Campesino();
            usuario1.Nombre = "Juan ";
            usuario1.Estrato = 2;
            usuario1.Genero = 0;

            Campesino usuario2 = new Campesino();
            usuario2.Nombre = "Luz ";
            usuario2.Estrato = 2;
            usuario2.Genero = 1;

            Campesino usuario3 = new Campesino();
            usuario3.Nombre = "Antonio ";
            usuario3.Estrato = 1;
            usuario3.Genero = 0;

            Campesino usuario4 = new Campesino();
            usuario4.Nombre = "Alba ";
            usuario4.Estrato = 2;
            usuario4.Genero = 1;

            Campesino usuario5 = new Campesino();
            usuario5.Nombre = "Jorge";
            usuario5.Estrato = 2;
            usuario5.Genero = 0;

            Sistema registro1 = new Sistema();
            registro1.Producto = Frijol;


        }
    }
}

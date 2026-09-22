using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class VidaRpg
{
    public string Nombre { get; }
    public int VidaMaxima { get; }
    public int VidaActual { get; private set; }
    public int AtaqueBase { get; }

    
    public VidaRpg(string nombre, int maxima, int ataque)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            nombre = "Sin nombre";
        if (maxima <= 0)
            maxima = 1;
        if (ataque <= 0)
            ataque = 1;

        Nombre = nombre.Trim();
        VidaMaxima = Math.Max(0, maxima);
        VidaActual = VidaMaxima;
        AtaqueBase = ataque;
    }

    public void RecibirDanyo(int cantidad)
    {
        if (cantidad < 0)
            return;
        VidaActual -= Math.Min(cantidad, VidaActual);
        if (VidaActual < 0)
            VidaActual = 0;
    }

    public void Curar(int cantidad)
    {
        if (cantidad < 0)
            return;
        int mejora = VidaMaxima - VidaActual;
        VidaActual += Math.Min(cantidad, mejora);
        
    }


    public override string ToString()
    {
        return $"{Nombre} {VidaActual}/{VidaMaxima}";
    }

}